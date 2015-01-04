namespace MyoPilot.UserSettings
{
    partial class SettingsForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageDrone = new System.Windows.Forms.TabPage();
            this.groupBoxControl = new System.Windows.Forms.GroupBox();
            this.numericUpDownRotationMax = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarRotationMax = new System.Windows.Forms.TrackBar();
            this.numericUpDownVerticalMax = new System.Windows.Forms.NumericUpDown();
            this.controlSectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarVerticalMax = new System.Windows.Forms.TrackBar();
            this.numericUpDownAltitudeMax = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarAltitudeMax = new System.Windows.Forms.TrackBar();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.keyboardSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonOk = new System.Windows.Forms.Button();
            this.numericUpDownTiltAngleMax = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarTiltAngleMax = new System.Windows.Forms.TrackBar();
            this.keyBox7 = new MyoPilot.UserSettings.KeyBox();
            this.keyBox8 = new MyoPilot.UserSettings.KeyBox();
            this.keyBox9 = new MyoPilot.UserSettings.KeyBox();
            this.keyBox10 = new MyoPilot.UserSettings.KeyBox();
            this.keyBox11 = new MyoPilot.UserSettings.KeyBox();
            this.keyBox12 = new MyoPilot.UserSettings.KeyBox();
            this.keyBox6 = new MyoPilot.UserSettings.KeyBox();
            this.keyBox5 = new MyoPilot.UserSettings.KeyBox();
            this.keyBox4 = new MyoPilot.UserSettings.KeyBox();
            this.keyBox3 = new MyoPilot.UserSettings.KeyBox();
            this.keyBox2 = new MyoPilot.UserSettings.KeyBox();
            this.keyBox1 = new MyoPilot.UserSettings.KeyBox();
            this.buttonLoadConfig = new System.Windows.Forms.Button();
            this.buttonSendConfig = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageDrone.SuspendLayout();
            this.groupBoxControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotationMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotationMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVerticalMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlSectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVerticalMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAltitudeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAltitudeMax)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyboardSettingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTiltAngleMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTiltAngleMax)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageDrone);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(621, 389);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageDrone
            // 
            this.tabPageDrone.AutoScroll = true;
            this.tabPageDrone.Controls.Add(this.buttonSendConfig);
            this.tabPageDrone.Controls.Add(this.buttonLoadConfig);
            this.tabPageDrone.Controls.Add(this.groupBoxControl);
            this.tabPageDrone.Location = new System.Drawing.Point(4, 22);
            this.tabPageDrone.Name = "tabPageDrone";
            this.tabPageDrone.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDrone.Size = new System.Drawing.Size(613, 363);
            this.tabPageDrone.TabIndex = 0;
            this.tabPageDrone.Text = "Drone";
            this.tabPageDrone.UseVisualStyleBackColor = true;
            // 
            // groupBoxControl
            // 
            this.groupBoxControl.Controls.Add(this.numericUpDownTiltAngleMax);
            this.groupBoxControl.Controls.Add(this.label4);
            this.groupBoxControl.Controls.Add(this.trackBarTiltAngleMax);
            this.groupBoxControl.Controls.Add(this.numericUpDownRotationMax);
            this.groupBoxControl.Controls.Add(this.label3);
            this.groupBoxControl.Controls.Add(this.trackBarRotationMax);
            this.groupBoxControl.Controls.Add(this.numericUpDownVerticalMax);
            this.groupBoxControl.Controls.Add(this.label2);
            this.groupBoxControl.Controls.Add(this.trackBarVerticalMax);
            this.groupBoxControl.Controls.Add(this.numericUpDownAltitudeMax);
            this.groupBoxControl.Controls.Add(this.label1);
            this.groupBoxControl.Controls.Add(this.trackBarAltitudeMax);
            this.groupBoxControl.Enabled = false;
            this.groupBoxControl.Location = new System.Drawing.Point(6, 37);
            this.groupBoxControl.Name = "groupBoxControl";
            this.groupBoxControl.Size = new System.Drawing.Size(414, 296);
            this.groupBoxControl.TabIndex = 1;
            this.groupBoxControl.TabStop = false;
            this.groupBoxControl.Text = "Control";
            // 
            // numericUpDownRotationMax
            // 
            this.numericUpDownRotationMax.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownRotationMax.Location = new System.Drawing.Point(318, 122);
            this.numericUpDownRotationMax.Maximum = new decimal(new int[] {
            350,
            0,
            0,
            0});
            this.numericUpDownRotationMax.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDownRotationMax.Name = "numericUpDownRotationMax";
            this.numericUpDownRotationMax.Size = new System.Drawing.Size(63, 20);
            this.numericUpDownRotationMax.TabIndex = 8;
            this.numericUpDownRotationMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownRotationMax.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDownRotationMax.ValueChanged += new System.EventHandler(this.numericUpDownRotationMax_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rotation Speed\r\n[degrees / s]";
            // 
            // trackBarRotationMax
            // 
            this.trackBarRotationMax.Location = new System.Drawing.Point(129, 121);
            this.trackBarRotationMax.Maximum = 350;
            this.trackBarRotationMax.Minimum = 40;
            this.trackBarRotationMax.Name = "trackBarRotationMax";
            this.trackBarRotationMax.Size = new System.Drawing.Size(182, 45);
            this.trackBarRotationMax.TabIndex = 6;
            this.trackBarRotationMax.TickFrequency = 10;
            this.trackBarRotationMax.Value = 40;
            this.trackBarRotationMax.Scroll += new System.EventHandler(this.trackBarRotationMax_Scroll);
            // 
            // numericUpDownVerticalMax
            // 
            this.numericUpDownVerticalMax.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.controlSectionBindingSource, "ControlVzMax", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDownVerticalMax.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownVerticalMax.Location = new System.Drawing.Point(318, 71);
            this.numericUpDownVerticalMax.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownVerticalMax.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownVerticalMax.Name = "numericUpDownVerticalMax";
            this.numericUpDownVerticalMax.Size = new System.Drawing.Size(63, 20);
            this.numericUpDownVerticalMax.TabIndex = 5;
            this.numericUpDownVerticalMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownVerticalMax.ThousandsSeparator = true;
            this.numericUpDownVerticalMax.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // controlSectionBindingSource
            // 
            this.controlSectionBindingSource.DataSource = typeof(AR.Drone.Client.Configuration.ControlSection);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vertical Speed\r\n[mm / s]";
            // 
            // trackBarVerticalMax
            // 
            this.trackBarVerticalMax.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.controlSectionBindingSource, "ControlVzMax", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.trackBarVerticalMax.LargeChange = 100;
            this.trackBarVerticalMax.Location = new System.Drawing.Point(129, 70);
            this.trackBarVerticalMax.Maximum = 2000;
            this.trackBarVerticalMax.Minimum = 200;
            this.trackBarVerticalMax.Name = "trackBarVerticalMax";
            this.trackBarVerticalMax.Size = new System.Drawing.Size(182, 45);
            this.trackBarVerticalMax.SmallChange = 50;
            this.trackBarVerticalMax.TabIndex = 3;
            this.trackBarVerticalMax.TickFrequency = 100;
            this.trackBarVerticalMax.Value = 200;
            // 
            // numericUpDownAltitudeMax
            // 
            this.numericUpDownAltitudeMax.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.controlSectionBindingSource, "AltitudeMax", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDownAltitudeMax.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownAltitudeMax.Location = new System.Drawing.Point(318, 20);
            this.numericUpDownAltitudeMax.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownAltitudeMax.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownAltitudeMax.Name = "numericUpDownAltitudeMax";
            this.numericUpDownAltitudeMax.Size = new System.Drawing.Size(63, 20);
            this.numericUpDownAltitudeMax.TabIndex = 2;
            this.numericUpDownAltitudeMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownAltitudeMax.ThousandsSeparator = true;
            this.numericUpDownAltitudeMax.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Maximum Altitude\r\n[mm]";
            // 
            // trackBarAltitudeMax
            // 
            this.trackBarAltitudeMax.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.controlSectionBindingSource, "AltitudeMax", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.trackBarAltitudeMax.LargeChange = 5000;
            this.trackBarAltitudeMax.Location = new System.Drawing.Point(129, 19);
            this.trackBarAltitudeMax.Maximum = 100000;
            this.trackBarAltitudeMax.Minimum = 3000;
            this.trackBarAltitudeMax.Name = "trackBarAltitudeMax";
            this.trackBarAltitudeMax.Size = new System.Drawing.Size(182, 45);
            this.trackBarAltitudeMax.SmallChange = 1000;
            this.trackBarAltitudeMax.TabIndex = 0;
            this.trackBarAltitudeMax.TickFrequency = 5000;
            this.trackBarAltitudeMax.Value = 3000;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.keyBox7);
            this.tabPage1.Controls.Add(this.keyBox8);
            this.tabPage1.Controls.Add(this.keyBox9);
            this.tabPage1.Controls.Add(this.keyBox10);
            this.tabPage1.Controls.Add(this.keyBox11);
            this.tabPage1.Controls.Add(this.keyBox12);
            this.tabPage1.Controls.Add(this.keyBox6);
            this.tabPage1.Controls.Add(this.keyBox5);
            this.tabPage1.Controls.Add(this.keyBox4);
            this.tabPage1.Controls.Add(this.keyBox3);
            this.tabPage1.Controls.Add(this.keyBox2);
            this.tabPage1.Controls.Add(this.keyBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(613, 363);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Keyboard";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // keyboardSettingsBindingSource
            // 
            this.keyboardSettingsBindingSource.DataSource = typeof(MyoPilot.UserSettings.KeyboardSettings);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(558, 407);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // numericUpDownTiltAngleMax
            // 
            this.numericUpDownTiltAngleMax.Location = new System.Drawing.Point(318, 173);
            this.numericUpDownTiltAngleMax.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownTiltAngleMax.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownTiltAngleMax.Name = "numericUpDownTiltAngleMax";
            this.numericUpDownTiltAngleMax.Size = new System.Drawing.Size(63, 20);
            this.numericUpDownTiltAngleMax.TabIndex = 11;
            this.numericUpDownTiltAngleMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownTiltAngleMax.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownTiltAngleMax.ValueChanged += new System.EventHandler(this.numericUpDownTiltAngleMax_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tilt Angle\r\n[degrees]";
            // 
            // trackBarTiltAngleMax
            // 
            this.trackBarTiltAngleMax.Location = new System.Drawing.Point(129, 172);
            this.trackBarTiltAngleMax.Maximum = 30;
            this.trackBarTiltAngleMax.Minimum = 5;
            this.trackBarTiltAngleMax.Name = "trackBarTiltAngleMax";
            this.trackBarTiltAngleMax.Size = new System.Drawing.Size(182, 45);
            this.trackBarTiltAngleMax.TabIndex = 9;
            this.trackBarTiltAngleMax.TickFrequency = 5;
            this.trackBarTiltAngleMax.Value = 5;
            this.trackBarTiltAngleMax.Scroll += new System.EventHandler(this.trackBarTiltAngleMax_Scroll);
            // 
            // keyBox7
            // 
            this.keyBox7.ActionText = "Flat Trim";
            this.keyBox7.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.keyboardSettingsBindingSource, "FlatTrim", true));
            this.keyBox7.Location = new System.Drawing.Point(6, 380);
            this.keyBox7.Name = "keyBox7";
            this.keyBox7.Size = new System.Drawing.Size(297, 28);
            this.keyBox7.TabIndex = 11;
            this.keyBox7.Value = 0;
            // 
            // keyBox8
            // 
            this.keyBox8.ActionText = "Emergency";
            this.keyBox8.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.keyboardSettingsBindingSource, "Emergency", true));
            this.keyBox8.Location = new System.Drawing.Point(6, 346);
            this.keyBox8.Name = "keyBox8";
            this.keyBox8.Size = new System.Drawing.Size(297, 28);
            this.keyBox8.TabIndex = 10;
            this.keyBox8.Value = 0;
            // 
            // keyBox9
            // 
            this.keyBox9.ActionText = "Land";
            this.keyBox9.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.keyboardSettingsBindingSource, "Land", true));
            this.keyBox9.Location = new System.Drawing.Point(6, 312);
            this.keyBox9.Name = "keyBox9";
            this.keyBox9.Size = new System.Drawing.Size(297, 28);
            this.keyBox9.TabIndex = 9;
            this.keyBox9.Value = 0;
            // 
            // keyBox10
            // 
            this.keyBox10.ActionText = "Takeoff";
            this.keyBox10.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.keyboardSettingsBindingSource, "Takeoff", true));
            this.keyBox10.Location = new System.Drawing.Point(6, 278);
            this.keyBox10.Name = "keyBox10";
            this.keyBox10.Size = new System.Drawing.Size(297, 28);
            this.keyBox10.TabIndex = 8;
            this.keyBox10.Value = 0;
            // 
            // keyBox11
            // 
            this.keyBox11.ActionText = "Turn Right";
            this.keyBox11.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.keyboardSettingsBindingSource, "Clockwise", true));
            this.keyBox11.Location = new System.Drawing.Point(6, 244);
            this.keyBox11.Name = "keyBox11";
            this.keyBox11.Size = new System.Drawing.Size(297, 28);
            this.keyBox11.TabIndex = 7;
            this.keyBox11.Value = 0;
            // 
            // keyBox12
            // 
            this.keyBox12.ActionText = "Turn Left";
            this.keyBox12.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.keyboardSettingsBindingSource, "CounterClockwise", true));
            this.keyBox12.Location = new System.Drawing.Point(6, 210);
            this.keyBox12.Name = "keyBox12";
            this.keyBox12.Size = new System.Drawing.Size(297, 28);
            this.keyBox12.TabIndex = 6;
            this.keyBox12.Value = 0;
            // 
            // keyBox6
            // 
            this.keyBox6.ActionText = "Down";
            this.keyBox6.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.keyboardSettingsBindingSource, "Down", true));
            this.keyBox6.Location = new System.Drawing.Point(6, 176);
            this.keyBox6.Name = "keyBox6";
            this.keyBox6.Size = new System.Drawing.Size(297, 28);
            this.keyBox6.TabIndex = 5;
            this.keyBox6.Value = 0;
            // 
            // keyBox5
            // 
            this.keyBox5.ActionText = "Up";
            this.keyBox5.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.keyboardSettingsBindingSource, "Up", true));
            this.keyBox5.Location = new System.Drawing.Point(6, 142);
            this.keyBox5.Name = "keyBox5";
            this.keyBox5.Size = new System.Drawing.Size(297, 28);
            this.keyBox5.TabIndex = 4;
            this.keyBox5.Value = 0;
            // 
            // keyBox4
            // 
            this.keyBox4.ActionText = "Right";
            this.keyBox4.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.keyboardSettingsBindingSource, "Right", true));
            this.keyBox4.Location = new System.Drawing.Point(6, 108);
            this.keyBox4.Name = "keyBox4";
            this.keyBox4.Size = new System.Drawing.Size(297, 28);
            this.keyBox4.TabIndex = 3;
            this.keyBox4.Value = 0;
            // 
            // keyBox3
            // 
            this.keyBox3.ActionText = "Left";
            this.keyBox3.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.keyboardSettingsBindingSource, "Left", true));
            this.keyBox3.Location = new System.Drawing.Point(6, 74);
            this.keyBox3.Name = "keyBox3";
            this.keyBox3.Size = new System.Drawing.Size(297, 28);
            this.keyBox3.TabIndex = 2;
            this.keyBox3.Value = 0;
            // 
            // keyBox2
            // 
            this.keyBox2.ActionText = "Backward";
            this.keyBox2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.keyboardSettingsBindingSource, "Backward", true));
            this.keyBox2.Location = new System.Drawing.Point(6, 40);
            this.keyBox2.Name = "keyBox2";
            this.keyBox2.Size = new System.Drawing.Size(297, 28);
            this.keyBox2.TabIndex = 1;
            this.keyBox2.Value = 0;
            // 
            // keyBox1
            // 
            this.keyBox1.ActionText = "Forward";
            this.keyBox1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.keyboardSettingsBindingSource, "Forward", true));
            this.keyBox1.Location = new System.Drawing.Point(6, 6);
            this.keyBox1.Name = "keyBox1";
            this.keyBox1.Size = new System.Drawing.Size(297, 28);
            this.keyBox1.TabIndex = 0;
            this.keyBox1.Value = 0;
            // 
            // buttonLoadConfig
            // 
            this.buttonLoadConfig.Location = new System.Drawing.Point(159, 8);
            this.buttonLoadConfig.Name = "buttonLoadConfig";
            this.buttonLoadConfig.Size = new System.Drawing.Size(114, 23);
            this.buttonLoadConfig.TabIndex = 2;
            this.buttonLoadConfig.Text = "Load Configuration";
            this.buttonLoadConfig.UseVisualStyleBackColor = true;
            this.buttonLoadConfig.Click += new System.EventHandler(this.buttonLoadConfig_Click);
            // 
            // buttonSendConfig
            // 
            this.buttonSendConfig.Location = new System.Drawing.Point(279, 8);
            this.buttonSendConfig.Name = "buttonSendConfig";
            this.buttonSendConfig.Size = new System.Drawing.Size(114, 23);
            this.buttonSendConfig.TabIndex = 3;
            this.buttonSendConfig.Text = "Send Configuration";
            this.buttonSendConfig.UseVisualStyleBackColor = true;
            this.buttonSendConfig.Click += new System.EventHandler(this.buttonSendConfig_Click);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 442);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.tabControl.ResumeLayout(false);
            this.tabPageDrone.ResumeLayout(false);
            this.groupBoxControl.ResumeLayout(false);
            this.groupBoxControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotationMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotationMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVerticalMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlSectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVerticalMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAltitudeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAltitudeMax)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.keyboardSettingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTiltAngleMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTiltAngleMax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageDrone;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TabPage tabPage1;
        private KeyBox keyBox1;
        private KeyBox keyBox7;
        private KeyBox keyBox8;
        private KeyBox keyBox9;
        private KeyBox keyBox10;
        private KeyBox keyBox11;
        private KeyBox keyBox12;
        private KeyBox keyBox6;
        private KeyBox keyBox5;
        private KeyBox keyBox4;
        private KeyBox keyBox3;
        private KeyBox keyBox2;
        private System.Windows.Forms.BindingSource keyboardSettingsBindingSource;
        private System.Windows.Forms.TrackBar trackBarAltitudeMax;
        private System.Windows.Forms.GroupBox groupBoxControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownAltitudeMax;
        private System.Windows.Forms.BindingSource controlSectionBindingSource;
        private System.Windows.Forms.NumericUpDown numericUpDownVerticalMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarVerticalMax;
        private System.Windows.Forms.NumericUpDown numericUpDownRotationMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBarRotationMax;
        private System.Windows.Forms.NumericUpDown numericUpDownTiltAngleMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarTiltAngleMax;
        private System.Windows.Forms.Button buttonLoadConfig;
        private System.Windows.Forms.Button buttonSendConfig;
    }
}