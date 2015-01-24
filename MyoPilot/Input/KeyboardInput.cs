using AR.Drone.Client.Command;
using MyoPilot.UserSettings;
using System.Windows.Input;

namespace MyoPilot.Input
{
    public class KeyboardInput : Input
    {
        /// <summary>
        /// Set to false to disable processing of the KeyboardState. 
        /// Useful when the application is minimized/not focused
        /// </summary>
        public bool Active { get; set; }

        public override void processInput()
        {
            if (Active)
            {
                processMovement();
                processActions();
            }
        }

        /// <summary>
        /// Process movement of the drone
        /// </summary>
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
        
        /// <summary>
        /// Process every command that is not movement
        /// </summary>
        private void processActions()
        {
            if (Keyboard.IsKeyDown((Key)KeyboardSettings.Default.Takeoff))
                OnTakeoff();

            if (Keyboard.IsKeyDown((Key)KeyboardSettings.Default.Land))
                OnLand();

            if (Keyboard.IsKeyDown((Key)KeyboardSettings.Default.Emergency))
                OnEmergency();

            if (Keyboard.IsKeyDown((Key)KeyboardSettings.Default.FlatTrim))
                OnFlatTrim();
        }
    }
}
