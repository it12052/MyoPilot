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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timerVideoUpdate = new System.Windows.Forms.Timer(this.components);
            this.videoFrame = new System.Windows.Forms.PictureBox();
            this.timerInput = new System.Windows.Forms.Timer(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelDown = new System.Windows.Forms.Label();
            this.labelBackward = new System.Windows.Forms.Label();
            this.labelRight = new System.Windows.Forms.Label();
            this.labelLeft = new System.Windows.Forms.Label();
            this.labelUp = new System.Windows.Forms.Label();
            this.labelRotateRight = new System.Windows.Forms.Label();
            this.labelRotateLeft = new System.Windows.Forms.Label();
            this.labelForward = new System.Windows.Forms.Label();
            this.timerStatusUpdate = new System.Windows.Forms.Timer(this.components);
            this.labelDroneStatus = new System.Windows.Forms.Label();
            this.buttonResetEmergency = new System.Windows.Forms.Button();
            this.uISettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.batteryGauge = new MyoPilot.BatteryGauge();
            this.labelAngles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.videoFrame)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uISettingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // timerVideoUpdate
            // 
            this.timerVideoUpdate.Interval = 20;
            this.timerVideoUpdate.Tick += new System.EventHandler(this.timerVideoUpdate_Tick);
            // 
            // videoFrame
            // 
            this.videoFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoFrame.Location = new System.Drawing.Point(0, 24);
            this.videoFrame.Name = "videoFrame";
            this.videoFrame.Size = new System.Drawing.Size(640, 360);
            this.videoFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.videoFrame.TabIndex = 0;
            this.videoFrame.TabStop = false;
            // 
            // timerInput
            // 
            this.timerInput.Interval = 30;
            this.timerInput.Tick += new System.EventHandler(this.timerInput_Tick);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(640, 24);
            this.menuStrip.TabIndex = 1;
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.labelDown, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelBackward, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelRight, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelLeft, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelUp, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelRotateRight, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelRotateLeft, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelForward, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 384);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // labelDown
            // 
            this.labelDown.AutoSize = true;
            this.labelDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDown.ForeColor = System.Drawing.Color.Black;
            this.labelDown.Location = new System.Drawing.Point(153, 66);
            this.labelDown.Name = "labelDown";
            this.labelDown.Size = new System.Drawing.Size(44, 34);
            this.labelDown.TabIndex = 11;
            this.labelDown.Text = "";
            this.labelDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBackward
            // 
            this.labelBackward.AutoSize = true;
            this.labelBackward.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBackward.ForeColor = System.Drawing.Color.Black;
            this.labelBackward.Location = new System.Drawing.Point(53, 66);
            this.labelBackward.Name = "labelBackward";
            this.labelBackward.Size = new System.Drawing.Size(44, 34);
            this.labelBackward.TabIndex = 9;
            this.labelBackward.Text = "";
            this.labelBackward.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRight
            // 
            this.labelRight.AutoSize = true;
            this.labelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRight.ForeColor = System.Drawing.Color.Black;
            this.labelRight.Location = new System.Drawing.Point(103, 33);
            this.labelRight.Name = "labelRight";
            this.labelRight.Size = new System.Drawing.Size(44, 33);
            this.labelRight.TabIndex = 6;
            this.labelRight.Text = "";
            this.labelRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLeft
            // 
            this.labelLeft.AutoSize = true;
            this.labelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLeft.ForeColor = System.Drawing.Color.Black;
            this.labelLeft.Location = new System.Drawing.Point(3, 33);
            this.labelLeft.Name = "labelLeft";
            this.labelLeft.Size = new System.Drawing.Size(44, 33);
            this.labelLeft.TabIndex = 4;
            this.labelLeft.Text = "";
            this.labelLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUp
            // 
            this.labelUp.AutoSize = true;
            this.labelUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUp.ForeColor = System.Drawing.Color.Black;
            this.labelUp.Location = new System.Drawing.Point(153, 0);
            this.labelUp.Name = "labelUp";
            this.labelUp.Size = new System.Drawing.Size(44, 33);
            this.labelUp.TabIndex = 3;
            this.labelUp.Text = "";
            this.labelUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRotateRight
            // 
            this.labelRotateRight.AutoSize = true;
            this.labelRotateRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRotateRight.ForeColor = System.Drawing.Color.Black;
            this.labelRotateRight.Location = new System.Drawing.Point(103, 0);
            this.labelRotateRight.Name = "labelRotateRight";
            this.labelRotateRight.Size = new System.Drawing.Size(44, 33);
            this.labelRotateRight.TabIndex = 2;
            this.labelRotateRight.Text = "";
            this.labelRotateRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRotateLeft
            // 
            this.labelRotateLeft.AutoSize = true;
            this.labelRotateLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRotateLeft.ForeColor = System.Drawing.Color.Black;
            this.labelRotateLeft.Location = new System.Drawing.Point(3, 0);
            this.labelRotateLeft.Name = "labelRotateLeft";
            this.labelRotateLeft.Size = new System.Drawing.Size(44, 33);
            this.labelRotateLeft.TabIndex = 1;
            this.labelRotateLeft.Text = "";
            this.labelRotateLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelForward
            // 
            this.labelForward.AutoSize = true;
            this.labelForward.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelForward.ForeColor = System.Drawing.Color.Black;
            this.labelForward.Location = new System.Drawing.Point(53, 0);
            this.labelForward.Name = "labelForward";
            this.labelForward.Size = new System.Drawing.Size(44, 33);
            this.labelForward.TabIndex = 0;
            this.labelForward.Text = "";
            this.labelForward.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerStatusUpdate
            // 
            this.timerStatusUpdate.Interval = 500;
            this.timerStatusUpdate.Tick += new System.EventHandler(this.timerStatusUpdate_Tick);
            // 
            // labelDroneStatus
            // 
            this.labelDroneStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDroneStatus.AutoSize = true;
            this.labelDroneStatus.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.uISettingsBindingSource, "DebugInfo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.labelDroneStatus.Location = new System.Drawing.Point(410, 387);
            this.labelDroneStatus.Name = "labelDroneStatus";
            this.labelDroneStatus.Size = new System.Drawing.Size(73, 13);
            this.labelDroneStatus.TabIndex = 3;
            this.labelDroneStatus.Text = "Disconnected";
            // 
            // buttonResetEmergency
            // 
            this.buttonResetEmergency.Location = new System.Drawing.Point(293, 450);
            this.buttonResetEmergency.Name = "buttonResetEmergency";
            this.buttonResetEmergency.Size = new System.Drawing.Size(107, 23);
            this.buttonResetEmergency.TabIndex = 5;
            this.buttonResetEmergency.Text = "Reset Emergency";
            this.buttonResetEmergency.UseVisualStyleBackColor = true;
            this.buttonResetEmergency.Visible = false;
            this.buttonResetEmergency.Click += new System.EventHandler(this.buttonResetEmergency_Click);
            // 
            // uISettingsBindingSource
            // 
            this.uISettingsBindingSource.DataSource = typeof(MyoPilot.UserSettings.UISettings);
            // 
            // batteryGauge
            // 
            this.batteryGauge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.batteryGauge.Enabled = false;
            this.batteryGauge.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryGauge.Location = new System.Drawing.Point(203, 450);
            this.batteryGauge.Name = "batteryGauge";
            this.batteryGauge.Size = new System.Drawing.Size(84, 28);
            this.batteryGauge.TabIndex = 4;
            this.batteryGauge.TabStop = false;
            this.batteryGauge.Text = "batteryGauge";
            // 
            // labelAngles
            // 
            this.labelAngles.AutoSize = true;
            this.labelAngles.Location = new System.Drawing.Point(526, 387);
            this.labelAngles.Name = "labelAngles";
            this.labelAngles.Size = new System.Drawing.Size(34, 52);
            this.labelAngles.TabIndex = 6;
            this.labelAngles.Text = "Roll:\r\nPitch:\r\nYaw:\r\nGaz:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 484);
            this.Controls.Add(this.labelAngles);
            this.Controls.Add(this.buttonResetEmergency);
            this.Controls.Add(this.batteryGauge);
            this.Controls.Add(this.labelDroneStatus);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.videoFrame);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "MyoPilot";
            ((System.ComponentModel.ISupportInitialize)(this.videoFrame)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uISettingsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerVideoUpdate;
        private System.Windows.Forms.PictureBox videoFrame;
        private System.Windows.Forms.Timer timerInput;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelDown;
        private System.Windows.Forms.Label labelBackward;
        private System.Windows.Forms.Label labelRight;
        private System.Windows.Forms.Label labelLeft;
        private System.Windows.Forms.Label labelUp;
        private System.Windows.Forms.Label labelRotateRight;
        private System.Windows.Forms.Label labelRotateLeft;
        private System.Windows.Forms.Label labelForward;
        private System.Windows.Forms.Timer timerStatusUpdate;
        private System.Windows.Forms.Label labelDroneStatus;
        private BatteryGauge batteryGauge;
        private System.Windows.Forms.Button buttonResetEmergency;
        private System.Windows.Forms.BindingSource uISettingsBindingSource;
        private System.Windows.Forms.Label labelAngles;
    }
}

