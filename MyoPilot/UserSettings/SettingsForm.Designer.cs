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
            this.groupBoxOutdoor = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonIndoors = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonOutdoors = new System.Windows.Forms.RadioButton();
            this.buttonSendConfig = new System.Windows.Forms.Button();
            this.buttonLoadConfig = new System.Windows.Forms.Button();
            this.groupBoxControl = new System.Windows.Forms.GroupBox();
            this.numericUpDownTiltAngleMax = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarTiltAngleMax = new System.Windows.Forms.TrackBar();
            this.numericUpDownRotationMax = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarRotationMax = new System.Windows.Forms.TrackBar();
            this.numericUpDownVerticalMax = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarVerticalMax = new System.Windows.Forms.TrackBar();
            this.numericUpDownAltitudeMax = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarAltitudeMax = new System.Windows.Forms.TrackBar();
            this.tabPageKeyboard = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.keyBoxFlatTrim = new MyoPilot.UserSettings.KeyBox();
            this.keyBoxEmergency = new MyoPilot.UserSettings.KeyBox();
            this.keyBoxLand = new MyoPilot.UserSettings.KeyBox();
            this.keyBoxTakeoff = new MyoPilot.UserSettings.KeyBox();
            this.keyBoxTurnRight = new MyoPilot.UserSettings.KeyBox();
            this.keyBoxTurnLeft = new MyoPilot.UserSettings.KeyBox();
            this.keyBoxDown = new MyoPilot.UserSettings.KeyBox();
            this.keyBoxUp = new MyoPilot.UserSettings.KeyBox();
            this.keyBoxRight = new MyoPilot.UserSettings.KeyBox();
            this.keyBoxLeft = new MyoPilot.UserSettings.KeyBox();
            this.keyBoxBackward = new MyoPilot.UserSettings.KeyBox();
            this.keyBoxForward = new MyoPilot.UserSettings.KeyBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.tabPageController = new System.Windows.Forms.TabPage();
            this.radioButtonIndoorHull = new System.Windows.Forms.RadioButton();
            this.radioButtonOutdoorHull = new System.Windows.Forms.RadioButton();
            this.controlSectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.keyboardSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tabPageDrone.SuspendLayout();
            this.groupBoxOutdoor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTiltAngleMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTiltAngleMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotationMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotationMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVerticalMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVerticalMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAltitudeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAltitudeMax)).BeginInit();
            this.tabPageKeyboard.SuspendLayout();
            this.tabPageController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlSectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyboardSettingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageDrone);
            this.tabControl.Controls.Add(this.tabPageKeyboard);
            this.tabControl.Controls.Add(this.tabPageController);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(620, 388);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageDrone
            // 
            this.tabPageDrone.AutoScroll = true;
            this.tabPageDrone.Controls.Add(this.groupBoxOutdoor);
            this.tabPageDrone.Controls.Add(this.buttonSendConfig);
            this.tabPageDrone.Controls.Add(this.buttonLoadConfig);
            this.tabPageDrone.Controls.Add(this.groupBoxControl);
            this.tabPageDrone.Location = new System.Drawing.Point(4, 22);
            this.tabPageDrone.Name = "tabPageDrone";
            this.tabPageDrone.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDrone.Size = new System.Drawing.Size(612, 362);
            this.tabPageDrone.TabIndex = 0;
            this.tabPageDrone.Text = "Drone";
            this.tabPageDrone.UseVisualStyleBackColor = true;
            // 
            // groupBoxOutdoor
            // 
            this.groupBoxOutdoor.Controls.Add(this.radioButtonIndoorHull);
            this.groupBoxOutdoor.Controls.Add(this.radioButtonOutdoorHull);
            this.groupBoxOutdoor.Controls.Add(this.label6);
            this.groupBoxOutdoor.Controls.Add(this.panel1);
            this.groupBoxOutdoor.Enabled = false;
            this.groupBoxOutdoor.Location = new System.Drawing.Point(6, 277);
            this.groupBoxOutdoor.Name = "groupBoxOutdoor";
            this.groupBoxOutdoor.Size = new System.Drawing.Size(361, 110);
            this.groupBoxOutdoor.TabIndex = 4;
            this.groupBoxOutdoor.TabStop = false;
            this.groupBoxOutdoor.Text = "Outdoor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Hull";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonIndoors);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.radioButtonOutdoors);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 19);
            this.panel1.TabIndex = 1;
            // 
            // radioButtonIndoors
            // 
            this.radioButtonIndoors.AutoSize = true;
            this.radioButtonIndoors.Location = new System.Drawing.Point(196, -2);
            this.radioButtonIndoors.Name = "radioButtonIndoors";
            this.radioButtonIndoors.Size = new System.Drawing.Size(60, 17);
            this.radioButtonIndoors.TabIndex = 1;
            this.radioButtonIndoors.TabStop = true;
            this.radioButtonIndoors.Text = "Indoors";
            this.radioButtonIndoors.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Flight";
            // 
            // radioButtonOutdoors
            // 
            this.radioButtonOutdoors.AutoSize = true;
            this.radioButtonOutdoors.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.controlSectionBindingSource, "Outdoor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.radioButtonOutdoors.Location = new System.Drawing.Point(98, -2);
            this.radioButtonOutdoors.Name = "radioButtonOutdoors";
            this.radioButtonOutdoors.Size = new System.Drawing.Size(68, 17);
            this.radioButtonOutdoors.TabIndex = 0;
            this.radioButtonOutdoors.TabStop = true;
            this.radioButtonOutdoors.Text = "Outdoors";
            this.radioButtonOutdoors.UseVisualStyleBackColor = true;
            // 
            // buttonSendConfig
            // 
            this.buttonSendConfig.Location = new System.Drawing.Point(279, 14);
            this.buttonSendConfig.Name = "buttonSendConfig";
            this.buttonSendConfig.Size = new System.Drawing.Size(114, 23);
            this.buttonSendConfig.TabIndex = 3;
            this.buttonSendConfig.Text = "Send Configuration";
            this.buttonSendConfig.UseVisualStyleBackColor = true;
            this.buttonSendConfig.Click += new System.EventHandler(this.buttonSendConfig_Click);
            // 
            // buttonLoadConfig
            // 
            this.buttonLoadConfig.Location = new System.Drawing.Point(159, 14);
            this.buttonLoadConfig.Name = "buttonLoadConfig";
            this.buttonLoadConfig.Size = new System.Drawing.Size(114, 23);
            this.buttonLoadConfig.TabIndex = 2;
            this.buttonLoadConfig.Text = "Load Configuration";
            this.buttonLoadConfig.UseVisualStyleBackColor = true;
            this.buttonLoadConfig.Click += new System.EventHandler(this.buttonLoadConfig_Click);
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
            this.groupBoxControl.Location = new System.Drawing.Point(6, 43);
            this.groupBoxControl.Name = "groupBoxControl";
            this.groupBoxControl.Size = new System.Drawing.Size(361, 227);
            this.groupBoxControl.TabIndex = 1;
            this.groupBoxControl.TabStop = false;
            this.groupBoxControl.Text = "Control";
            // 
            // numericUpDownTiltAngleMax
            // 
            this.numericUpDownTiltAngleMax.Location = new System.Drawing.Point(289, 172);
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
            this.trackBarTiltAngleMax.Location = new System.Drawing.Point(101, 172);
            this.trackBarTiltAngleMax.Maximum = 30;
            this.trackBarTiltAngleMax.Minimum = 5;
            this.trackBarTiltAngleMax.Name = "trackBarTiltAngleMax";
            this.trackBarTiltAngleMax.Size = new System.Drawing.Size(182, 45);
            this.trackBarTiltAngleMax.TabIndex = 9;
            this.trackBarTiltAngleMax.TickFrequency = 5;
            this.trackBarTiltAngleMax.Value = 5;
            this.trackBarTiltAngleMax.Scroll += new System.EventHandler(this.trackBarTiltAngleMax_Scroll);
            // 
            // numericUpDownRotationMax
            // 
            this.numericUpDownRotationMax.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownRotationMax.Location = new System.Drawing.Point(289, 122);
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
            this.trackBarRotationMax.Location = new System.Drawing.Point(101, 122);
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
            this.numericUpDownVerticalMax.Location = new System.Drawing.Point(289, 70);
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
            this.trackBarVerticalMax.Location = new System.Drawing.Point(101, 70);
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
            this.numericUpDownAltitudeMax.Location = new System.Drawing.Point(289, 19);
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
            this.trackBarAltitudeMax.Location = new System.Drawing.Point(101, 19);
            this.trackBarAltitudeMax.Maximum = 100000;
            this.trackBarAltitudeMax.Minimum = 3000;
            this.trackBarAltitudeMax.Name = "trackBarAltitudeMax";
            this.trackBarAltitudeMax.Size = new System.Drawing.Size(182, 45);
            this.trackBarAltitudeMax.SmallChange = 1000;
            this.trackBarAltitudeMax.TabIndex = 0;
            this.trackBarAltitudeMax.TickFrequency = 5000;
            this.trackBarAltitudeMax.Value = 3000;
            // 
            // tabPageKeyboard
            // 
            this.tabPageKeyboard.AutoScroll = true;
            this.tabPageKeyboard.Controls.Add(this.label18);
            this.tabPageKeyboard.Controls.Add(this.label17);
            this.tabPageKeyboard.Controls.Add(this.label16);
            this.tabPageKeyboard.Controls.Add(this.label15);
            this.tabPageKeyboard.Controls.Add(this.label14);
            this.tabPageKeyboard.Controls.Add(this.label13);
            this.tabPageKeyboard.Controls.Add(this.label12);
            this.tabPageKeyboard.Controls.Add(this.label11);
            this.tabPageKeyboard.Controls.Add(this.label10);
            this.tabPageKeyboard.Controls.Add(this.label9);
            this.tabPageKeyboard.Controls.Add(this.label8);
            this.tabPageKeyboard.Controls.Add(this.label7);
            this.tabPageKeyboard.Controls.Add(this.keyBoxFlatTrim);
            this.tabPageKeyboard.Controls.Add(this.keyBoxEmergency);
            this.tabPageKeyboard.Controls.Add(this.keyBoxLand);
            this.tabPageKeyboard.Controls.Add(this.keyBoxTakeoff);
            this.tabPageKeyboard.Controls.Add(this.keyBoxTurnRight);
            this.tabPageKeyboard.Controls.Add(this.keyBoxTurnLeft);
            this.tabPageKeyboard.Controls.Add(this.keyBoxDown);
            this.tabPageKeyboard.Controls.Add(this.keyBoxUp);
            this.tabPageKeyboard.Controls.Add(this.keyBoxRight);
            this.tabPageKeyboard.Controls.Add(this.keyBoxLeft);
            this.tabPageKeyboard.Controls.Add(this.keyBoxBackward);
            this.tabPageKeyboard.Controls.Add(this.keyBoxForward);
            this.tabPageKeyboard.Location = new System.Drawing.Point(4, 22);
            this.tabPageKeyboard.Name = "tabPageKeyboard";
            this.tabPageKeyboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKeyboard.Size = new System.Drawing.Size(612, 362);
            this.tabPageKeyboard.TabIndex = 1;
            this.tabPageKeyboard.Text = "Keyboard";
            this.tabPageKeyboard.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(321, 98);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "Flat Trim";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(308, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 13);
            this.label17.TabIndex = 22;
            this.label17.Text = "Emergency";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(337, 40);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Land";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(324, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Takeoff";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(59, 214);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Turn Right";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(66, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Turn Left";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(81, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Down";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(95, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Up";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(84, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Right";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(91, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Left";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Backward";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Forward";
            // 
            // keyBoxFlatTrim
            // 
            this.keyBoxFlatTrim.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.keyboardSettingsBindingSource, "FlatTrim", true));
            this.keyBoxFlatTrim.Location = new System.Drawing.Point(374, 93);
            this.keyBoxFlatTrim.Name = "keyBoxFlatTrim";
            this.keyBoxFlatTrim.Size = new System.Drawing.Size(117, 23);
            this.keyBoxFlatTrim.TabIndex = 11;
            this.keyBoxFlatTrim.Value = 0;
            // 
            // keyBoxEmergency
            // 
            this.keyBoxEmergency.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.keyboardSettingsBindingSource, "Emergency", true));
            this.keyBoxEmergency.Location = new System.Drawing.Point(374, 64);
            this.keyBoxEmergency.Name = "keyBoxEmergency";
            this.keyBoxEmergency.Size = new System.Drawing.Size(117, 23);
            this.keyBoxEmergency.TabIndex = 10;
            this.keyBoxEmergency.Value = 0;
            // 
            // keyBoxLand
            // 
            this.keyBoxLand.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.keyboardSettingsBindingSource, "Land", true));
            this.keyBoxLand.Location = new System.Drawing.Point(374, 35);
            this.keyBoxLand.Name = "keyBoxLand";
            this.keyBoxLand.Size = new System.Drawing.Size(117, 23);
            this.keyBoxLand.TabIndex = 9;
            this.keyBoxLand.Value = 0;
            // 
            // keyBoxTakeoff
            // 
            this.keyBoxTakeoff.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.keyboardSettingsBindingSource, "Takeoff", true));
            this.keyBoxTakeoff.Location = new System.Drawing.Point(374, 6);
            this.keyBoxTakeoff.Name = "keyBoxTakeoff";
            this.keyBoxTakeoff.Size = new System.Drawing.Size(117, 23);
            this.keyBoxTakeoff.TabIndex = 8;
            this.keyBoxTakeoff.Value = 0;
            // 
            // keyBoxTurnRight
            // 
            this.keyBoxTurnRight.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.keyboardSettingsBindingSource, "Clockwise", true));
            this.keyBoxTurnRight.Location = new System.Drawing.Point(122, 209);
            this.keyBoxTurnRight.Name = "keyBoxTurnRight";
            this.keyBoxTurnRight.Size = new System.Drawing.Size(117, 23);
            this.keyBoxTurnRight.TabIndex = 7;
            this.keyBoxTurnRight.Value = 0;
            // 
            // keyBoxTurnLeft
            // 
            this.keyBoxTurnLeft.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.keyboardSettingsBindingSource, "CounterClockwise", true));
            this.keyBoxTurnLeft.Location = new System.Drawing.Point(122, 180);
            this.keyBoxTurnLeft.Name = "keyBoxTurnLeft";
            this.keyBoxTurnLeft.Size = new System.Drawing.Size(117, 23);
            this.keyBoxTurnLeft.TabIndex = 6;
            this.keyBoxTurnLeft.Value = 0;
            // 
            // keyBoxDown
            // 
            this.keyBoxDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.keyboardSettingsBindingSource, "Down", true));
            this.keyBoxDown.Location = new System.Drawing.Point(122, 151);
            this.keyBoxDown.Name = "keyBoxDown";
            this.keyBoxDown.Size = new System.Drawing.Size(117, 23);
            this.keyBoxDown.TabIndex = 5;
            this.keyBoxDown.Value = 0;
            // 
            // keyBoxUp
            // 
            this.keyBoxUp.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.keyboardSettingsBindingSource, "Up", true));
            this.keyBoxUp.Location = new System.Drawing.Point(122, 122);
            this.keyBoxUp.Name = "keyBoxUp";
            this.keyBoxUp.Size = new System.Drawing.Size(117, 23);
            this.keyBoxUp.TabIndex = 4;
            this.keyBoxUp.Value = 0;
            // 
            // keyBoxRight
            // 
            this.keyBoxRight.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.keyboardSettingsBindingSource, "Right", true));
            this.keyBoxRight.Location = new System.Drawing.Point(122, 93);
            this.keyBoxRight.Name = "keyBoxRight";
            this.keyBoxRight.Size = new System.Drawing.Size(117, 23);
            this.keyBoxRight.TabIndex = 3;
            this.keyBoxRight.Value = 0;
            // 
            // keyBoxLeft
            // 
            this.keyBoxLeft.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.keyboardSettingsBindingSource, "Left", true));
            this.keyBoxLeft.Location = new System.Drawing.Point(122, 64);
            this.keyBoxLeft.Name = "keyBoxLeft";
            this.keyBoxLeft.Size = new System.Drawing.Size(117, 23);
            this.keyBoxLeft.TabIndex = 2;
            this.keyBoxLeft.Value = 0;
            // 
            // keyBoxBackward
            // 
            this.keyBoxBackward.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.keyboardSettingsBindingSource, "Backward", true));
            this.keyBoxBackward.Location = new System.Drawing.Point(122, 35);
            this.keyBoxBackward.Name = "keyBoxBackward";
            this.keyBoxBackward.Size = new System.Drawing.Size(117, 23);
            this.keyBoxBackward.TabIndex = 1;
            this.keyBoxBackward.Value = 0;
            // 
            // keyBoxForward
            // 
            this.keyBoxForward.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.keyboardSettingsBindingSource, "Forward", true));
            this.keyBoxForward.Location = new System.Drawing.Point(122, 6);
            this.keyBoxForward.Name = "keyBoxForward";
            this.keyBoxForward.Size = new System.Drawing.Size(117, 23);
            this.keyBoxForward.TabIndex = 0;
            this.keyBoxForward.Value = 0;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(557, 406);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // tabPageController
            // 
            this.tabPageController.Controls.Add(this.pictureBox1);
            this.tabPageController.Location = new System.Drawing.Point(4, 22);
            this.tabPageController.Name = "tabPageController";
            this.tabPageController.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageController.Size = new System.Drawing.Size(612, 362);
            this.tabPageController.TabIndex = 2;
            this.tabPageController.Text = "Controller";
            this.tabPageController.UseVisualStyleBackColor = true;
            // 
            // radioButtonIndoorHull
            // 
            this.radioButtonIndoorHull.AutoSize = true;
            this.radioButtonIndoorHull.Image = global::MyoPilot.Properties.Resources.drone_32x32_;
            this.radioButtonIndoorHull.Location = new System.Drawing.Point(199, 53);
            this.radioButtonIndoorHull.Name = "radioButtonIndoorHull";
            this.radioButtonIndoorHull.Size = new System.Drawing.Size(55, 49);
            this.radioButtonIndoorHull.TabIndex = 4;
            this.radioButtonIndoorHull.TabStop = true;
            this.radioButtonIndoorHull.Text = "Indoor";
            this.radioButtonIndoorHull.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radioButtonIndoorHull.UseVisualStyleBackColor = true;
            // 
            // radioButtonOutdoorHull
            // 
            this.radioButtonOutdoorHull.AutoSize = true;
            this.radioButtonOutdoorHull.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.controlSectionBindingSource, "FlightWithoutShell", true));
            this.radioButtonOutdoorHull.Image = global::MyoPilot.Properties.Resources.drone_wo_hull_32x32_;
            this.radioButtonOutdoorHull.Location = new System.Drawing.Point(101, 53);
            this.radioButtonOutdoorHull.Name = "radioButtonOutdoorHull";
            this.radioButtonOutdoorHull.Size = new System.Drawing.Size(63, 49);
            this.radioButtonOutdoorHull.TabIndex = 3;
            this.radioButtonOutdoorHull.TabStop = true;
            this.radioButtonOutdoorHull.Text = "Outdoor";
            this.radioButtonOutdoorHull.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radioButtonOutdoorHull.UseVisualStyleBackColor = true;
            // 
            // controlSectionBindingSource
            // 
            this.controlSectionBindingSource.DataSource = typeof(AR.Drone.Client.Configuration.ControlSection);
            // 
            // keyboardSettingsBindingSource
            // 
            this.keyboardSettingsBindingSource.DataSource = typeof(MyoPilot.UserSettings.KeyboardSettings);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MyoPilot.Properties.Resources.xbox360_controller;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(606, 356);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 441);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.tabControl.ResumeLayout(false);
            this.tabPageDrone.ResumeLayout(false);
            this.groupBoxOutdoor.ResumeLayout(false);
            this.groupBoxOutdoor.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxControl.ResumeLayout(false);
            this.groupBoxControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTiltAngleMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTiltAngleMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRotationMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotationMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVerticalMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVerticalMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAltitudeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAltitudeMax)).EndInit();
            this.tabPageKeyboard.ResumeLayout(false);
            this.tabPageKeyboard.PerformLayout();
            this.tabPageController.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.controlSectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyboardSettingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageDrone;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TabPage tabPageKeyboard;
        private KeyBox keyBoxForward;
        private KeyBox keyBoxFlatTrim;
        private KeyBox keyBoxEmergency;
        private KeyBox keyBoxLand;
        private KeyBox keyBoxTakeoff;
        private KeyBox keyBoxTurnRight;
        private KeyBox keyBoxTurnLeft;
        private KeyBox keyBoxDown;
        private KeyBox keyBoxUp;
        private KeyBox keyBoxRight;
        private KeyBox keyBoxLeft;
        private KeyBox keyBoxBackward;
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
        private System.Windows.Forms.GroupBox groupBoxOutdoor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonIndoors;
        private System.Windows.Forms.RadioButton radioButtonOutdoors;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonOutdoorHull;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButtonIndoorHull;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPageController;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}