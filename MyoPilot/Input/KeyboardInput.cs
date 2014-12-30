using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MyoPilot.UserSettings;
using AR.Drone.Client.Command;

namespace MyoPilot.Input
{
    public class KeyboardInput : Input
    {
        public override void processInput()
        {
            processMovement();
            processActions();
        }

        private void processMovement()
        {
            float roll = 0.0f;
            float pitch = 0.0f;
            float yaw = 0.0f;
            float gaz = 0.0f;


            if (Keyboard.IsKeyDown((Key)KeyboardSettings.Default.Left))
                roll = -1.0f;
            else if (Keyboard.IsKeyDown((Key)KeyboardSettings.Default.Right))
                roll = +1.0f;

            if (Keyboard.IsKeyDown((Key)KeyboardSettings.Default.Forward))
                pitch = -1.0f;
            else if (Keyboard.IsKeyDown((Key)KeyboardSettings.Default.Backward))
                pitch = +1.0f;

            if (Keyboard.IsKeyDown((Key)KeyboardSettings.Default.CounterClockwise))
                yaw = -1.0f;
            else if (Keyboard.IsKeyDown((Key)KeyboardSettings.Default.Clockwise))
                yaw = +1.0f;

            if (Keyboard.IsKeyDown((Key)KeyboardSettings.Default.Down))
                gaz = -1.0f;
            else if (Keyboard.IsKeyDown((Key)KeyboardSettings.Default.Up))
                gaz = +1.0f;

            if (roll != 0.0f || pitch != 0.0f || yaw != 0.0f || gaz != 0.0f)
                OnProgress(FlightMode.Progressive, roll, pitch, yaw, gaz);
        }
        
        private void processActions()
        {
            if (Keyboard.IsKeyDown((Key)KeyboardSettings.Default.Takeoff))
                OnTakeoff();

            if (Keyboard.IsKeyDown((Key)KeyboardSettings.Default.Land))
                OnLand();

            if (Keyboard.IsKeyDown((Key)KeyboardSettings.Default.Emergency))
                OnEmergency();

            if (Keyboard.IsKeyDown((Key)KeyboardSettings.Default.Trim))
                OnFlatTrim();
        }
    }
}
