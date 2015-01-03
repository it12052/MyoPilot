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
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.keyboardSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonOk = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyboardSettingsBindingSource)).BeginInit();
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
            this.tabPageDrone.Location = new System.Drawing.Point(4, 22);
            this.tabPageDrone.Name = "tabPageDrone";
            this.tabPageDrone.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDrone.Size = new System.Drawing.Size(613, 363);
            this.tabPageDrone.TabIndex = 0;
            this.tabPageDrone.Text = "Drone";
            this.tabPageDrone.UseVisualStyleBackColor = true;
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
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.keyboardSettingsBindingSource)).EndInit();
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
    }
}