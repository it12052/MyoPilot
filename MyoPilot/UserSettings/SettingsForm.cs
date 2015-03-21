using AR.Drone.Client;
using AR.Drone.Client.Configuration;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyoPilot.UserSettings
{
    public partial class SettingsForm : Form
    {
        /// <summary>
        /// Occurs before the settings are sent to the drone
        /// </summary>
        public event EventHandler ChangeDroneSettingsBegin;
        /// <summary>
        /// Occurs after the settings have been sent to the drone
        /// </summary>
        public event EventHandler ChangeDroneSettingsEnd;

        protected void OnChangeDroneSettingsBegin()
        {
            if (ChangeDroneSettingsBegin != null)
                ChangeDroneSettingsBegin(this, EventArgs.Empty);
        }
        protected void OnChangeDroneSettingsEnd()
        {
            if (ChangeDroneSettingsEnd != null)
                ChangeDroneSettingsEnd(this, EventArgs.Empty);
        }

        private DroneClient droneClient;
        private Settings settings;

        public SettingsForm(DroneClient droneClient)
        {
            this.droneClient = droneClient;

            InitializeComponent();

            ReadDroneConfig();

            keyboardSettingsBindingSource.Add(KeyboardSettings.Default);
            myoSettingsBindingSource.Add(MyoSettings.Default);
        }

        /// <summary>
        /// Requests the current configuration from the drone asynchronously.
        /// Triggers OnSettingsReceived when completed
        /// Settings/Results are loaded to the settings variale
        /// </summary>
        private void ReadDroneConfig()
        {
            // If the drone is not connected, droneClient will throw an exception 
            // although there is some exeption handling
            if (droneClient.IsConnected)
            {
                Task<Settings> configurationTask = droneClient.GetConfigurationTask();
                configurationTask.ContinueWith(delegate(Task<Settings> task)
                {
                    if (task.Exception != null)
                    {
                        Trace.TraceWarning("Get configuration task is faulted with exception: {0}", task.Exception.InnerException.Message);
                        return;
                    }

                    settings = task.Result;
                    this.Invoke(new SettingsReceived(OnSettingsReceived));
                });
                configurationTask.Start();
            }
        }

        delegate void SettingsReceived();
        /// <summary>
        /// Updates the UI with the received settings
        /// </summary>
        private void OnSettingsReceived()
        {
            controlSectionBindingSource.Clear();
            controlSectionBindingSource.Add(settings.Control);
            groupBoxControl.Enabled = true;
            groupBoxOutdoor.Enabled = true;
            groupBoxVideo.Enabled = true;

            // Update Controlls which are not bound
            numericUpDownRotationMax.Value = (int)convertRadToDeg(settings.Control.ControlYaw);
            trackBarRotationMax.Value = (int)convertRadToDeg(settings.Control.ControlYaw);
            numericUpDownTiltAngleMax.Value = (int)convertRadToDeg(settings.Control.EulerAngleMax);
            trackBarTiltAngleMax.Value = (int)convertRadToDeg(settings.Control.EulerAngleMax);

            // The other radioButtons are initialized with databinding
            if (!settings.Control.Outdoor)
                radioButtonIndoors.Checked = true;
            if (!settings.Control.FlightWithoutShell)
                radioButtonIndoorHull.Checked = true;
            if (settings.Video.Codec == VideoCodecType.H264_360P)
                radioButtonVideo360p.Checked = true;
            else if (settings.Video.Codec == VideoCodecType.H264_720P)
                radioButtonVideo720p.Checked = true;
        }

        /// <summary>
        /// Sends the changed settings from the UI to the drone
        /// </summary>
        private void SendDroneConfig()
        {
            if (droneClient.IsConnected)
            {
                OnChangeDroneSettingsBegin();
                var sendConfigTask = new Task(() =>
                {
                    if (settings == null) 
                        settings = new Settings();

                    if (string.IsNullOrEmpty(settings.Custom.SessionId) ||
                        settings.Custom.SessionId == "00000000")
                    {
                        // set new session, application and profile
                        droneClient.AckControlAndWaitForConfirmation(); // wait for the control confirmation

                        settings.Custom.SessionId = Settings.NewId();
                        droneClient.Send(settings);

                        droneClient.AckControlAndWaitForConfirmation();

                        settings.Custom.ProfileId = Settings.NewId();
                        droneClient.Send(settings);

                        droneClient.AckControlAndWaitForConfirmation();

                        settings.Custom.ApplicationId = Settings.NewId();
                        droneClient.Send(settings);

                        droneClient.AckControlAndWaitForConfirmation();
                    }

                    settings.General.NavdataDemo = false;
                    settings.General.NavdataOptions = NavdataOptions.All;

                    settings.Video.BitrateCtrlMode = VideoBitrateControlMode.Dynamic;
                    settings.Video.Bitrate = 2000;
                    settings.Video.MaxBitrate = 4000;

                    //settings.Leds.LedAnimation = new LedAnimation(LedAnimationType.BlinkGreenRed, 2.0f, 2);
                    //settings.Control.FlightAnimation = new FlightAnimation(FlightAnimationType.Wave);

                    // record video to usb
                    //settings.Video.OnUsb = true;
                    // usage of MP4_360P_H264_720P codec is a requirement for video recording to usb
                    //settings.Video.Codec = VideoCodecType.MP4_360P_H264_720P;
                    // start
                    //settings.Userbox.Command = new UserboxCommand(UserboxCommandType.Start);
                    // stop
                    //settings.Userbox.Command = new UserboxCommand(UserboxCommandType.Stop);


                    //send all changes in one pice
                    droneClient.Send(settings);
                });
                sendConfigTask.Start(); 
                sendConfigTask.Wait();
                OnChangeDroneSettingsEnd();
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            KeyboardSettings.Default.Save();
            
            base.OnClosed(e);
        }

        #region .Manual Databinding.
        /*
         * The controlls use databinding to synchronize the value between the trackBar and the numericUpDown.
         * However, this approach is not possible for rotation and tiltAngle, because they are displayed in
         * degrees (trackBars don't allow decimal values, and it is more meaningful) but are saved in radians,
         * therefore they have to be converted.
         */

        private void trackBarRotationMax_Scroll(object sender, EventArgs e)
        {
            settings.Control.ControlYaw = convertDegToRad(trackBarRotationMax.Value);
            controlSectionBindingSource.ResetCurrentItem();

            numericUpDownRotationMax.Value = trackBarRotationMax.Value;
        }

        private void numericUpDownRotationMax_ValueChanged(object sender, EventArgs e)
        {
            settings.Control.ControlYaw = convertDegToRad((float)numericUpDownRotationMax.Value);
            controlSectionBindingSource.ResetCurrentItem();

            trackBarRotationMax.Value = (int)numericUpDownRotationMax.Value;
        }

        private void trackBarTiltAngleMax_Scroll(object sender, EventArgs e)
        {
            settings.Control.EulerAngleMax = convertDegToRad(trackBarTiltAngleMax.Value);
            controlSectionBindingSource.ResetCurrentItem();

            numericUpDownTiltAngleMax.Value = trackBarTiltAngleMax.Value;
        }

        private void numericUpDownTiltAngleMax_ValueChanged(object sender, EventArgs e)
        {
            settings.Control.EulerAngleMax = convertDegToRad((float)numericUpDownTiltAngleMax.Value);
            controlSectionBindingSource.ResetCurrentItem();

            trackBarTiltAngleMax.Value = (int)numericUpDownTiltAngleMax.Value;
        }

        /// <summary>
        /// Convert angles in degrees to radians
        /// </summary>
        /// <param name="value">angle [degrees]</param>
        /// <returns>angle [radians]</returns>
        private float convertDegToRad(float value)
        {
            float result = value / 360f;
            result = result * 2f * (float)Math.PI;
            return result;
        }

        /// <summary>
        /// Convert angles in radians to degrees
        /// </summary>
        /// <param name="value">angle [radians]</param>
        /// <returns>angle [degrees]</returns>
        private float convertRadToDeg(float value)
        {
            float result = value / (2f * (float)Math.PI);
            result = result * 360f;
            return result;
        }

        private void radioButtonVideo360p_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonVideo360p.Checked)
                settings.Video.Codec = VideoCodecType.H264_360P;
        }

        private void radioButtonVideo720p_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonVideo720p.Checked)
                settings.Video.Codec = VideoCodecType.H264_720P;
        }
        #endregion
        
        private void buttonLoadConfig_Click(object sender, EventArgs e)
        {
            ReadDroneConfig();
        }

        private void buttonSendConfig_Click(object sender, EventArgs e)
        {
            SendDroneConfig();
        }
    }
}
