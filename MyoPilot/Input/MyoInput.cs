using AR.Drone.Client.Command;
using MyoNet.Myo;
using MyoPilot.UserSettings;
using System;
using System.Threading;

namespace MyoPilot.Input
{
    /// <summary>
    /// Input module responsible to process data from the Myo device
    /// </summary>
    public class MyoInput : Input
    {
        /// <summary>
        /// Set to false to disable processing of the KeyboardState. 
        /// Useful when the application is minimized/not focused
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Lock to coordinate concurrent access
        /// </summary>
        protected Object myLock = new Object();

        protected Hub hub;
        protected IMyo myo = null;

        protected Quaternion currentOrientation;
        protected Quaternion referenceOrientation;
        protected Pose currentPose;
        protected bool onArm = false;
        protected bool takeoffLand = false;
        
        /// <summary>
        /// Initialize the Myo input module. Will throw an exception if no Myo is available
        /// </summary>
        public MyoInput()
        {
            Active = true;

            hub = new Hub("de.dhbw.MyoPilot");
            myo = hub.WaitForMyo(TimeSpan.FromSeconds(5));
            if (myo == null)
                throw new TimeoutException("Unable to find a Myo!");

            hub.MyoUnpaired += OnUnpair;

            myo.PoseChanged += OnPoseChanged;
            myo.OrientationDataAcquired += OnOrientationData;
            myo.RecognizedArm += OnRecognizedArm;
            myo.LostArm += OnLostArm;
            myo.Unlock(UnlockType.Hold);

            // hub.Run() needs to run permanently in order to receive events from the Myo
            Thread worker = new Thread(hub.Run) { IsBackground = true, Name = "MyoBackgroundWorker" };
            worker.Start();
        }

        public override void processInput()
        {
            lock (myLock)
            {
                if (Active && myo != null && onArm)
                {
                    double myoRoll, myoPitch, myoYaw;
                    float droneRoll, dronePitch, droneYaw, droneGaz;

                    CalculateRelativeEulerAngles(out myoRoll, out myoPitch, out myoYaw);
                    RerangeEulerAngles(ref myoRoll, ref myoPitch, ref myoYaw);

                    if (takeoffLand)
                    {
                        // take-off or land
                        OnTakeoff();
                        OnLand();
                        takeoffLand = false;
                    }
                    else if (currentPose == Pose.FingersSpread)
                    {
                        // Vertical movement
                        droneGaz = (float)myoPitch;
                        OnProgress(FlightMode.Progressive, gaz: droneGaz);
                    }
                    else if (currentPose == Pose.Fist)
                    {
                        // Horizontal movement
                        droneRoll = (float)-myoYaw;
                        dronePitch = (float)myoPitch;
                        droneYaw = (float)-myoRoll;
                        OnProgress(FlightMode.Progressive, droneRoll, dronePitch, droneYaw);
                    }
                }
            }
        }

        /// <summary>
        /// Calculate all relative angles between the current orientation and the reference orientation
        /// </summary>
        /// <param name="roll"></param>
        /// <param name="pitch"></param>
        /// <param name="yaw"></param>
        protected void CalculateRelativeEulerAngles(out double roll, out double pitch, out double yaw)
        {
            lock (myLock)
            {
                double currentRoll = Quaternion.Roll(currentOrientation);
                double currentPitch = Quaternion.Pitch(currentOrientation);
                double currentYaw = Quaternion.Yaw(currentOrientation);

                double referenceRoll = Quaternion.Roll(referenceOrientation);
                double referencePitch = Quaternion.Pitch(referenceOrientation);
                double referenceYaw = Quaternion.Yaw(referenceOrientation);

                roll = CalculateRelativeAngle(currentRoll, referenceRoll);
                pitch = CalculateRelativeAngle(currentPitch, referencePitch);
                yaw = CalculateRelativeAngle(currentYaw, referenceYaw);
            }
        }

        /// <summary>
        /// Calculate one relative angle between the current angle and the reference angle
        /// </summary>
        /// <param name="current">Current angle</param>
        /// <param name="reference">Reference for the relative angle</param>
        /// <returns></returns>
        protected double CalculateRelativeAngle(double current, double reference)
        {
            // Because our domain is circular (-PI and +PI are the same) we calculate
            // the smallest difference and return that
            double diff1 = current - 2 * Math.PI - reference;
            double diff2 = current - reference;
            double diff3 = current + 2 * Math.PI - reference;

            double abs1 = Math.Abs(diff1);
            double abs2 = Math.Abs(diff2);
            double abs3 = Math.Abs(diff3);

            double min = Math.Min(abs1, Math.Min(abs2, abs3));

            if (min == abs1) return diff1;
            if (min == abs3) return diff3;
            else return diff2;
        }

        /// <summary>
        /// Rerange the angles to [-1 - +1]
        /// If one angle is in the deadzone it is set to 0
        /// Angles are cubed for better control
        /// Deadzone and max is configurable in MyoSettings.settings
        /// </summary>
        /// <param name="roll">roll</param>
        /// <param name="pitch">pitch</param>
        /// <param name="yaw">yaw</param>
        protected void RerangeEulerAngles(ref double roll, ref double pitch, ref double yaw)
        {
            RerangeEulerAngle(ref roll, MyoSettings.Default.rollDeadzone, MyoSettings.Default.rollMax);
            RerangeEulerAngle(ref pitch, MyoSettings.Default.pitchDeadzone, MyoSettings.Default.pitchMax);
            RerangeEulerAngle(ref yaw, MyoSettings.Default.yawDeadzone, MyoSettings.Default.yawMax);
        }

        /// <summary>
        /// Rerange the angles to [-1 - +1]
        /// If one angle is in the deadzone it is set to 0
        /// Angles are cubed for better control
        /// </summary>
        /// <param name="angle">angle to rerange</param>
        /// <param name="deadzone">Must be positive</param>
        /// <param name="max">Must be greater than deadzone</param>
        protected void RerangeEulerAngle(ref double angle, double deadzone, double max)
        {
            int sign = Math.Sign(angle);
            double value = Math.Abs(angle);

            if (Math.Abs(angle) < deadzone)
            {
                angle = 0;
                return;
            }
            else
            {
                // current range of value: [deadzone - inifinite]
                value = Math.Min(value, max);
                // current range of value: [deadzone - max]
                value -= deadzone;
                // current range of value: [0 - (max - deadzone)]
                value /= (max - deadzone);
                // current range of value: [0 - 1]

                angle = sign * Math.Pow(value, 3);
                return;
            }
        }

        // OnUnpair() is called whenever the Myo is disconnected from Myo Connect by the user.    
        protected void OnUnpair(object sender, MyoEventArgs e)
        {
            lock (myLock)
            {
                myo = null;
                onArm = false;
            }
        }

        protected void OnOrientationData(object sender, OrientationDataEventArgs e)
        {
            lock (myLock)
                currentOrientation = e.Orientation;
        }

        // OnPose() is called whenever the Myo detects that the person wearing it has changed their pose, for example,
        // making a fist, or not making a fist anymore.
        protected void OnPoseChanged(object sender, PoseChangedEventArgs e)
        {
            lock (myLock)
            {
                if (currentPose == Pose.Fist || currentPose == Pose.FingersSpread)
                {
                    e.Myo.Vibrate(VibrationType.Short);
                }

                currentPose = e.Pose;

                if (e.Pose == Pose.Fist || e.Pose == Pose.FingersSpread)
                {
                    referenceOrientation = currentOrientation;
                    e.Myo.Vibrate(VibrationType.Short);
                }
                else if (e.Pose == Pose.DoubleTap)
                {
                    e.Myo.Vibrate(VibrationType.Medium);
                    takeoffLand = true;
                }
            }
        }

        protected void OnRecognizedArm(object sender, RecognizedArmEventArgs e)
        {
            lock (myLock)
                onArm = true;
        }

        protected void OnLostArm(object sender, MyoEventArgs e)
        {
            lock (myLock)
                onArm = false;
        }
    }
}
