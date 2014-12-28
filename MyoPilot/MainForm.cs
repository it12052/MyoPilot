using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AR.Drone.Client;
using AR.Drone.Client.Command;
using AR.Drone.Client.Configuration;
using AR.Drone.Data;
using AR.Drone.Data.Navigation;
using AR.Drone.Data.Navigation.Native;
using AR.Drone.Media;
using AR.Drone.Video;
using AR.Drone.WinApp;

namespace MyoPilot
{
    public partial class MainForm : Form
    {
        private readonly DroneClient droneClient;
        private readonly VideoPacketDecoderWorker videoPacketDecoderWorker;
        private Settings settings;
        private VideoFrame frame;
        private Bitmap frameBitmap;
        private uint frameNumber;
        private NavigationData navigationData;

        public MainForm()
        {
            InitializeComponent();

            videoPacketDecoderWorker = new VideoPacketDecoderWorker(PixelFormat.BGR24, true, OnVideoPacketDecoded);
            videoPacketDecoderWorker.Start();
            videoPacketDecoderWorker.UnhandledException += UnhandledException;

            droneClient = new DroneClient();
            droneClient.VideoPacketAcquired += OnVideoPacketAcquired;
            droneClient.NavigationDataAcquired += data => navigationData = data;
            droneClient.Start();
        }

        private void OnVideoPacketAcquired(VideoPacket packet)
        {
            if (videoPacketDecoderWorker.IsAlive)
                videoPacketDecoderWorker.EnqueuePacket(packet);
        }

        private void OnVideoPacketDecoded(VideoFrame frame)
        {
            this.frame = frame;
        }

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
    }
}
