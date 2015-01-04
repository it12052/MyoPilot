using AR.Drone.Client;
using AR.Drone.Client.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyoPilot.UserSettings
{
    public partial class SettingsForm : Form
    {
        private DroneClient droneClient;
        private Settings settings;

        public SettingsForm(DroneClient droneClient)
        {
            this.droneClient = droneClient;

            InitializeComponent();

            ReadDroneConfig();

            keyboardSettingsBindingSource.Add(KeyboardSettings.Default);
        }

        private void ReadDroneConfig()
        {
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
        private void OnSettingsReceived()
        {
            controlSectionBindingSource.Clear();
            controlSectionBindingSource.Add(settings.Control);
            groupBoxControl.Enabled = true;
        }


        private void SendDroneConfig()
        {
            if (droneClient.IsConnected)
            {
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
                    settings.Video.Bitrate = 1000;
                    settings.Video.MaxBitrate = 2000;

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
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            KeyboardSettings.Default.Save();
            
            base.OnClosed(e);
        }

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

        private float convertDegToRad(float value)
        {
            float result = value / 360f;
            result = result * 2f * (float)Math.PI;
            return result;
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
