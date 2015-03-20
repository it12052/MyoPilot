using MyoNet.Myo;
using System;
using System.Threading;
using AR.Drone.Client.Command;
using MyoPilot.UserSettings;

namespace MyoPilot.Input
{
    public class MyoInput : Input
    {
        private Object myLock = new Object();

        private Hub hub;
        private IMyo myo = null;

        private Quaternion currentOrientation;
        private Quaternion referenceOrientation;
        private Pose currentPose;
        private bool onArm = false;
        

        public MyoInput()
        {
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

            Thread worker = new Thread(hub.Run) { IsBackground = true, Name = "MyoBackgroundWorker" };
            worker.Start();
        }

        public override void processInput()
        {
            lock (myLock)
            {
                if (myo != null && onArm)
                {
                    double myoRoll, myoPitch, myoYaw;
                    float droneRoll, dronePitch, droneYaw, droneGaz;

                    CalculateRelativeEulerAngles(out myoRoll, out myoPitch, out myoYaw);
                    RerangeEulerAngles(ref myoRoll, ref myoPitch, ref myoYaw);

                    if (currentPose == Pose.DoubleTap)
                    {
                        OnTakeoff();
                        OnLand();
                    }
                    else if (currentPose == Pose.FingersSpread)
                    {
                        droneGaz = (float)myoPitch;
                        OnProgress(FlightMode.Progressive, gaz: droneGaz);
                    }
                    else if (currentPose == Pose.Fist)
                    {
                        droneRoll = (float)-myoYaw;
                        dronePitch = (float)myoPitch;
                        droneYaw = (float)-myoRoll;
                        OnProgress(FlightMode.Progressive, droneRoll, dronePitch, droneYaw);
                    }
                }
            }
        }

        /// <summary>
        /// Calculate the relative angles between the current orientation and the reference orientation
        /// </summary>
        /// <param name="roll"></param>
        /// <param name="pitch"></param>
        /// <param name="yaw"></param>
        private void CalculateRelativeEulerAngles(out double roll, out double pitch, out double yaw)
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
        /// Calculate the relative angle between the current angle and the reference angle
        /// </summary>
        /// <param name="current">Current angle</param>
        /// <param name="reference">Reference for the relative angle</param>
        /// <returns></returns>
        private double CalculateRelativeAngle(double current, double reference)
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
        /// If one angle is in the deathzone it is set to 0
        /// Angles are squared (with preserved sign) for better control
        /// Deathzone and max is configurable in MyoSettings.settings
        /// </summary>
        /// <param name="roll">roll</param>
        /// <param name="pitch">pitch</param>
        /// <param name="yaw">yaw</param>
        private void RerangeEulerAngles(ref double roll, ref double pitch, ref double yaw)
        {
            RerangeEulerAngle(ref roll, MyoSettings.Default.rollDeathzone, MyoSettings.Default.rollMax);
            RerangeEulerAngle(ref pitch, MyoSettings.Default.pitchDeathzone, MyoSettings.Default.pitchMax);
            RerangeEulerAngle(ref yaw, MyoSettings.Default.yawDeathzone, MyoSettings.Default.yawMax);
        }

        /// <summary>
        /// Rerange the angles to [-1 - +1]
        /// If one angle is in the deathzone it is set to 0
        /// Angles are squared (with preserved sign) for better control
        /// </summary>
        /// <param name="angle">angle to rerange</param>
        /// <param name="deathzone">Must be positive</param>
        /// <param name="max">Must be greater than deathzone</param>
        private void RerangeEulerAngle(ref double angle, double deathzone, double max)
        {
            int sign = Math.Sign(angle);
            double value = Math.Abs(angle);

            if (Math.Abs(angle) < deathzone)
            {
                angle = 0;
                return;
            }
            else
            {
                // [deathzone - inifinite]
                value = Math.Min(value, max);
                // [deathzone - max]
                value -= deathzone;
                // [0 - (max - deathzone)]
                value /= (max - deathzone);
                // [0 - 1]

                angle = sign * value * value;
                return;
            }
        }

        // OnUnpair() is called whenever the Myo is disconnected from Myo Connect by the user.    
        private void OnUnpair(object sender, MyoEventArgs e)
        {
            lock (myLock)
            {
                myo = null;
                onArm = false;
            }
        }

        private void OnOrientationData(object sender, OrientationDataEventArgs e)
        {
            lock (myLock)
                currentOrientation = e.Orientation;
        }

        // OnPose() is called whenever the Myo detects that the person wearing it has changed their pose, for example,
        // making a fist, or not making a fist anymore.
        private void OnPoseChanged(object sender, PoseChangedEventArgs e)
        {
            lock (myLock)
            {
                if ((currentPose == Pose.Fist || currentPose == Pose.FingersSpread)
                    && (e.Pose != Pose.Fist || e.Pose != Pose.FingersSpread))
                {
                    e.Myo.Vibrate(VibrationType.Short);
                }

                currentPose = e.Pose;

                if (e.Pose == Pose.Fist || e.Pose == Pose.FingersSpread)
                {
                    referenceOrientation = currentOrientation;
                    e.Myo.Vibrate(VibrationType.Short);
                }
            }
        }

        private void OnRecognizedArm(object sender, RecognizedArmEventArgs e)
        {
            lock (myLock)
                onArm = true;
        }

        private void OnLostArm(object sender, MyoEventArgs e)
        {
            lock (myLock)
                onArm = false;
        }
    }
}
