namespace MyoPilot.UserSettings
{
    partial class KeyBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyBox));
            this.labelValue = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(167, 8);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(68, 13);
            this.labelValue.TabIndex = 1;
            this.labelValue.Text = "(Press a key)";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 8);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(37, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Action";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonEdit.Image")));
            this.buttonEdit.Location = new System.Drawing.Point(269, 0);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(28, 28);
            this.buttonEdit.TabIndex = 0;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // KeyBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.buttonEdit);
            this.Name = "KeyBox";
            this.Size = new System.Drawing.Size(297, 28);
            this.Leave += new System.EventHandler(this.KeyBox_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label labelName;

    }
}
