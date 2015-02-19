using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Input;

namespace MyoPilot.UserSettings
{
    /// <summary>
    /// A button-like controll to capture and save a keypress as System.Windows.Input.Key value. 
    /// Does not capture [ALT] and [Escape]
    /// </summary>
    public class KeyBox : Button
    {
        // The following Windows message value is defined in Winuser.h. 
        private const int WM_KEYDOWN = 0x100;

        private Key _value;
        private KeyConverter keyConverter;
        private bool waitingForNewKey = false;

        public KeyBox()
        {
            keyConverter = new KeyConverter();
        }

        /// <summary>
        /// The Key-Code as integer
        /// </summary>
        [Category("Appearance")]
        [Description("Value of the key")]
        [Bindable(true)]
        [SettingsBindable(true)]
        public int Value
        {
            get
            {
                return (int)_value;
            }
            set
            {
                _value = (Key)value;
                this.Text = keyConverter.ConvertToString(_value);
            }
        }

        protected override void OnLeave(EventArgs e)
        {
            EndEdit();
            base.OnLeave(e);
        }

        protected override void OnClick(EventArgs e)
        {
            StartEdit();
            base.OnClick(e);
        }

        private void StartEdit()
        {
            if (waitingForNewKey == false)
            {
                this.Text = "(Press a key)";
                waitingForNewKey = true;
            }
        }

        private void EndEdit()
        {
            if (waitingForNewKey == true)
            {
                waitingForNewKey = false;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (msg.Msg == WM_KEYDOWN && waitingForNewKey)
            {
                extractPressedKey();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            // This would capture the ALT-key, but it conflicts with the menu-bar,
            // so we don't capture it
            /*if (waitingForNewKey)
            {
                extractPressedKey();
                return true;
            }*/
            return base.ProcessDialogKey(keyData);
        }

        /// <summary>
        /// Check which key is currently down. Save the pressed key to Value
        /// </summary>
        private void extractPressedKey()
        {
            Array keyValues = Enum.GetValues(typeof(Key));
            foreach (Key k in keyValues)
            {
                // Handling special Keys
                if (k == Key.None)
                    continue; // Calling Keyboard.IsKeyDown(Key.None) would trigger an exception

                if (Keyboard.IsKeyDown(k))
                {
                    if (k != Key.Escape)
                        Value = (int)k;
                    EndEdit();
                }
            }
        }
    }
}
