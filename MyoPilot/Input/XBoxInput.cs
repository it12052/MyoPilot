using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MyoPilot.UserSettings;
using AR.Drone.Client.Command;
using XInputDotNetPure;

namespace MyoPilot.Input
{
    public class XBoxInput : Input
    {
        public override void processInput()
        {
            GamePadState state = GamePad.GetState(PlayerIndex.One);
            if (state.IsConnected)
            {
                processMovement(state);
                processActions(state);
            }
        }

        private void processMovement(GamePadState state)
        {
            float roll = state.ThumbSticks.Left.X;
            roll = Math.Sign(roll) * roll * roll;

            float pitch = -state.ThumbSticks.Left.Y;
            pitch = Math.Sign(pitch) * pitch * pitch;

            float yaw = -state.Triggers.Left + state.Triggers.Right;
            yaw = Math.Sign(yaw) * yaw * yaw;

            float gaz = state.ThumbSticks.Right.Y;
            gaz = Math.Sign(gaz) * gaz * gaz;

            if (roll != 0.0f || pitch != 0.0f || yaw != 0.0f || gaz != 0.0f)
                OnProgress(FlightMode.Progressive, roll, pitch, yaw, gaz);
        }
        
        private void processActions(GamePadState state)
        {
            if (state.Buttons.A == ButtonState.Pressed)
                OnTakeoff();

            if (state.Buttons.A == ButtonState.Pressed)
                OnLand();

            if (state.Buttons.B == ButtonState.Pressed)
                OnEmergency();

            if (state.Buttons.Y == ButtonState.Pressed)
                OnFlatTrim();
        }
    }
}
