namespace MyoPilot
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerVideoUpdate = new System.Windows.Forms.Timer(this.components);
            this.videoFrame = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.videoFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // timerVideoUpdate
            // 
            this.timerVideoUpdate.Interval = 20;
            this.timerVideoUpdate.Tick += new System.EventHandler(this.timerVideoUpdate_Tick);
            // 
            // videoFrame
            // 
            this.videoFrame.Location = new System.Drawing.Point(25, 39);
            this.videoFrame.Name = "videoFrame";
            this.videoFrame.Size = new System.Drawing.Size(216, 152);
            this.videoFrame.TabIndex = 0;
            this.videoFrame.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.videoFrame);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.videoFrame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerVideoUpdate;
        private System.Windows.Forms.PictureBox videoFrame;
    }
}

