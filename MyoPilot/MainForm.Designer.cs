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
            this.timerInput = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
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
            this.videoFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoFrame.Location = new System.Drawing.Point(0, 24);
            this.videoFrame.Name = "videoFrame";
            this.videoFrame.Size = new System.Drawing.Size(784, 537);
            this.videoFrame.TabIndex = 0;
            this.videoFrame.TabStop = false;
            // 
            // timerInput
            // 
            this.timerInput.Interval = 30;
            this.timerInput.Tick += new System.EventHandler(this.timerInput_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.videoFrame);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MyoPilot";
            ((System.ComponentModel.ISupportInitialize)(this.videoFrame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerVideoUpdate;
        private System.Windows.Forms.PictureBox videoFrame;
        private System.Windows.Forms.Timer timerInput;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

