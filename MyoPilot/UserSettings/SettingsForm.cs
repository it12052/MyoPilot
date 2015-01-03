using AR.Drone.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyoPilot.UserSettings
{
    public partial class SettingsForm : Form
    {
        private DroneClient droneClient;

        public SettingsForm(DroneClient droneClient)
        {
            this.droneClient = droneClient;

            InitializeComponent();

            keyboardSettingsBindingSource.Add(KeyboardSettings.Default);
        }

        protected override void OnClosed(EventArgs e)
        {
            KeyboardSettings.Default.Save();
            
            base.OnClosed(e);
        }
    }
}
