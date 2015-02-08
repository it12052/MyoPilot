using AR.Drone.Client;
using AR.Drone.Client.Command;
using AR.Drone.Data;
using AR.Drone.Data.Navigation;
using AR.Drone.Video;
using AR.Drone.WinApp;
using MyoPilot.Input;
using MyoPilot.UserSettings;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace MyoPilot
{
    public partial class MainForm : Form
    {
        private readonly DroneClient droneClient;
        private VideoPacketDecoderWorker videoPacketDecoderWorker;
        private VideoFrame frame;
        private Bitmap frameBitmap;
        private uint frameNumber;
        private NavigationData navigationData;
        private InputManager inputManager;
        private PrivateFontCollection privateFontCollection;

        public MainForm()
        {
            InitializeComponent();

            droneClient = new DroneClient();
            droneClient.NavigationDataAcquired += data => navigationData = data;
            droneClient.VideoPacketAcquired += OnVideoPacketAcquired;
            droneClient.Start();

            InitializeVideo();

            LoadFontAwesome();
            InitInput();

            timerInput.Enabled = true;
            timerStatusUpdate.Enabled = true;
        }

        /// <summary>
        /// Load "FontAwesome" from C:\System\Fonts or from the application directory
        /// Assigns the Font to every control which needs it
        /// </summary>
        private void LoadFontAwesome()
        {
            string fontName = "FontAwesome";
            string fontFileName = "FontAwesome.otf";
            float fontSize = 16;
            Font fontAwesome = new Font(fontName, fontSize);
            // If the font is not installed, it will be substituted with Microsoft Sans Serif
            if (fontAwesome.Name != fontName)
            {
                // try loading the font from file
                string fontFile = Path.Combine(Environment.CurrentDirectory, fontFileName);
                if (File.Exists(fontFile))
                {
                    // privateFontCollection needs to be in scope while the font is used
                    // this is why it is a class variable and not a local one
                    privateFontCollection = new PrivateFontCollection();
                    privateFontCollection.AddFontFile(fontFile);
                    FontFamily family = privateFontCollection.Families[0];
                    fontAwesome = new Font(family, fontSize);
                }
                else
                {
                    MessageBox.Show("Font Awesome by Dave Gandy not found. The application might not work correctly. Please download " + fontFileName + 
                        " from http://fontawesome.io and either install it or drop it in the application folder (" + Environment.CurrentDirectory + ")",
                        "Cannot load FontAwesome", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            labelRotateLeft.Font = fontAwesome;
            labelRotateRight.Font = fontAwesome;
            labelForward.Font = fontAwesome;
            labelBackward.Font = fontAwesome;
            labelLeft.Font = fontAwesome;
            labelRight.Font = fontAwesome;
            labelUp.Font = fontAwesome;
            labelDown.Font = fontAwesome;
        }

        /// <summary>
        /// Initialize video processing
        /// </summary>
        private void InitializeVideo()
        {
            videoPacketDecoderWorker = new VideoPacketDecoderWorker(PixelFormat.BGR24, true, OnVideoPacketDecoded);
            videoPacketDecoderWorker.Start();
            videoPacketDecoderWorker.UnhandledException += UnhandledException;

            timerVideoUpdate.Enabled = true;
        }

        /// <summary>
        /// Stop video processing
        /// </summary>
        private void StopVideo()
        {
            timerVideoUpdate.Enabled = false;

            videoPacketDecoderWorker.Stop();
            videoPacketDecoderWorker.Join();
            frame = null;
            frameBitmap = null;
        }

        /// <summary>
        /// Initialize Classes for Input handling 
        /// Add event listeners for everyone who wants to process incomming drone-commands (UI and Drone itself)
        /// </summary>
        private void InitInput()
        {
            KeyboardInput keyboardInput = new KeyboardInput();
            // Prevents input through keyboard when the app is not focused
            this.GotFocus += (sender, e) => keyboardInput.Active = true;
            this.LostFocus += (sender, e) => keyboardInput.Active = false;

            XBoxInput xBoxInput = new XBoxInput();

            inputManager = new InputManager();
            // Add UI Listeners
            inputManager.Emergency += inputManager_Emergency;
            //inputManager.FlatTrim += inputManager_FlatTrim;
            inputManager.Hover += inputManager_Hover;
            //inputManager.Land += inputManager_Land;
            inputManager.Progress += inputManager_Progress;
            //inputManager.Takeoff += inputManager_Takeoff;
            // Add droneClient listeners
            inputManager.Emergency += droneClient.Emergency;
            inputManager.FlatTrim += droneClient.FlatTrim;
            inputManager.Hover += droneClient.Hover;
            inputManager.Land += droneClient.Land;
            inputManager.Progress += droneClient.Progress;
            inputManager.Takeoff += droneClient.Takeoff;

            inputManager.addControl(keyboardInput);
            inputManager.addControl(xBoxInput);
        }

        #region Input handling

        /// <summary>
        /// Highlight the direction in which the drone move
        /// </summary>
        void inputManager_Progress(FlightMode mode, float roll = 0, float pitch = 0, float yaw = 0, float gaz = 0)
        {
            if (mode == FlightMode.Hover)
            {
                inputManager_Hover();
                return;
            }

            labelRotateLeft.ForeColor = yaw < 0 ? UISettings.Default.IconHighlightColor : UISettings.Default.IconDefaultColor;
            labelRotateRight.ForeColor = yaw > 0 ? UISettings.Default.IconHighlightColor : UISettings.Default.IconDefaultColor;
            labelForward.ForeColor = pitch < 0 ? UISettings.Default.IconHighlightColor : UISettings.Default.IconDefaultColor;
            labelBackward.ForeColor = pitch > 0 ? UISettings.Default.IconHighlightColor : UISettings.Default.IconDefaultColor;
            labelLeft.ForeColor = roll < 0 ? UISettings.Default.IconHighlightColor : UISettings.Default.IconDefaultColor;
            labelRight.ForeColor = roll > 0 ? UISettings.Default.IconHighlightColor : UISettings.Default.IconDefaultColor;
            labelUp.ForeColor = gaz > 0 ? UISettings.Default.IconHighlightColor : UISettings.Default.IconDefaultColor;
            labelDown.ForeColor = gaz < 0 ? UISettings.Default.IconHighlightColor : UISettings.Default.IconDefaultColor;
        }

        /// <summary>
        /// Reset all highlights in the UI
        /// </summary>
        void inputManager_Hover()
        {
            labelRotateLeft.ForeColor = UISettings.Default.IconDefaultColor;
            labelRotateRight.ForeColor = UISettings.Default.IconDefaultColor;
            labelForward.ForeColor = UISettings.Default.IconDefaultColor;
            labelBackward.ForeColor = UISettings.Default.IconDefaultColor;
            labelLeft.ForeColor = UISettings.Default.IconDefaultColor;
            labelRight.ForeColor = UISettings.Default.IconDefaultColor;
            labelUp.ForeColor = UISettings.Default.IconDefaultColor;
            labelDown.ForeColor = UISettings.Default.IconDefaultColor;
        }

        /// <summary>
        /// TODO: Use the dronestate to reset the emergency
        /// </summary>
        void inputManager_Emergency()
        {
            DialogResult res = MessageBox.Show("Press OK to reset emergency", "Emergency", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                droneClient.ResetEmergency();
            }
        }
        
        /// <summary>
        /// Trigger input processing
        /// </summary>
        private void timerInput_Tick(object sender, EventArgs e)
        {
            inputManager.processInput();
        }
        #endregion

        #region Videostreaming
        /// <summary>
        /// Queue Videopacket for encoding
        /// </summary>
        /// <param name="packet">VideoPacket</param>
        private void OnVideoPacketAcquired(VideoPacket packet)
        {
            if (videoPacketDecoderWorker.IsAlive)
                videoPacketDecoderWorker.EnqueuePacket(packet);
        }

        /// <summary>
        /// Save the current frame for the next render
        /// </summary>
        /// <param name="frame"></param>
        private void OnVideoPacketDecoded(VideoFrame frame)
        {
            this.frame = frame;
        }
        
        /// <summary>
        /// Render the latest video frame to the vidoeFrame PictureBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerVideoUpdate_Tick(object sender, EventArgs e)
        {
            if (frame == null || frameNumber == frame.Number)
                return;
            frameNumber = frame.Number;

            if (frameBitmap == null)
                frameBitmap = VideoHelper.CreateBitmap(ref frame);
            else
                VideoHelper.UpdateBitmap(ref frameBitmap, ref frame);

            videoFrame.Image = frameBitmap;
        }
        #endregion

        private void UnhandledException(object sender, Exception exception)
        {
            MessageBox.Show(exception.ToString(), "Unhandled Exception (Ctrl+C)", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Text += Environment.Is64BitProcess ? " [64-bit]" : " [32-bit]";
        }

        protected override void OnClosed(EventArgs e)
        {
            droneClient.Stop();
            droneClient.Dispose();
            videoPacketDecoderWorker.Dispose();

            base.OnClosed(e);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm dialog = new SettingsForm(droneClient);
            
            // We need to restart the video processor in case the user changed 
            // the resolution of the stream. Otherwise VideoHelper will run into
            // Memory Access Violations (very bad!) because of changed memory requirements
            dialog.ChangeDroneSettingsBegin += (s, args) => StopVideo();
            dialog.ChangeDroneSettingsEnd += (s, args) => InitializeVideo();

            dialog.ShowDialog();
        }

        /// <summary>
        /// Render status information
        /// </summary>
        private void timerStatusUpdate_Tick(object sender, EventArgs e)
        {
            string status = string.Format("{0}\nBattery: {1}%\nWifi: {2}\nDronestate: {3}\nResolution: {4}",
                droneClient.IsConnected ? "Connected\n" : "Disconnected\n",
                navigationData != null ? navigationData.Battery.Percentage.ToString() : "",
                navigationData != null ? navigationData.Wifi.LinkQuality : 0f,
                navigationData != null ? navigationData.State.ToString() : "",
                frameBitmap != null ? frameBitmap.Size.ToString() : "");

            labelDroneStatus.Text = status;
        }
                
    }
}
