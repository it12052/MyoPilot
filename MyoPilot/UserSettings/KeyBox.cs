using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace MyoPilot.UserSettings
{
    public class KeyBox : Button
    {
        // The following Windows message value is defined in Winuser.h. 
        private const int WM_KEYDOWN = 0x100;

        private Key _value;
        private KeyConverter keyConverter;
        private bool waitingForNewKey = false;
        private bool wasClickKeyUp;

        public KeyBox()
        {
            keyConverter = new KeyConverter();
        }

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
                wasClickKeyUp = false;
            }
        }

        private void EndEdit()
        {
            if (waitingForNewKey == true)
            {
                this.Text = keyConverter.ConvertToString(_value);
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

        private void extractPressedKey()
        {
            // It is possible to click a button witch Space or Return
            // If this happened, the key might still be down
            if (!wasClickKeyUp)
            {
                if (Keyboard.IsKeyUp(Key.Return) && Keyboard.IsKeyUp(Key.Space))
                {
                    wasClickKeyUp = true;
                }
            }

            Array keyValues = Enum.GetValues(typeof(Key));
            foreach (Key k in keyValues)
            {
                // Handling special Keys
                if (k == Key.None)
                    continue;
                else if (k == Key.Return || k == Key.Space)
                {
                    if (!wasClickKeyUp)
                    {
                        continue;
                    }
                }

                if (Keyboard.IsKeyDown(k))
                {
                    if (k != Key.Escape)
                        _value = k;
                    EndEdit();
                }
            }
        }
    }
}
