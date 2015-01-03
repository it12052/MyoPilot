using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Input;

namespace MyoPilot.UserSettings
{
    public partial class KeyBox : UserControl
    {
        // The following Windows message value is defined in Winuser.h. 
        private const int WM_KEYDOWN = 0x100;

        private Key _value;
        private KeyConverter keyConverter;
        private bool waitingForNewKey = false;
        private bool wasClickKeyUp;

        public KeyBox()
        {
            InitializeComponent();
            keyConverter = new KeyConverter();
        }

        [Category("Appearance")]
        [Description("Action associated with a keyboard key")]
        [Bindable(true)]
        [SettingsBindable(true)]
        public string ActionText
        {
            get
            {
                return labelName.Text;
            }
            set
            {
                labelName.Text = value;
            }
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
                labelValue.Text = keyConverter.ConvertToString(_value);
            }
        }

        private void KeyBox_Leave(object sender, EventArgs e)
        {
            EndEdit();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            StartEdit();
        }

        private void StartEdit()
        {
            if (waitingForNewKey == false)
            {
                labelValue.Text = "(Press a key)";
                waitingForNewKey = true;
                wasClickKeyUp = false;
            }
        }

        private void EndEdit()
        {
            if (waitingForNewKey == true)
            {
                labelValue.Text = keyConverter.ConvertToString(_value);
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
            if (waitingForNewKey)
            {
                extractPressedKey();
                return true;
            }
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
                    _value = k;
                    EndEdit();
                }
            }
        }
    }
}