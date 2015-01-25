using AR.Drone.Client.Command;
using System;
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

        /// <summary>
        /// Process movement of the drone
        /// </summary>
        /// <param name="state">GamePadState</param>
        private void processMovement(GamePadState state)
        {
            float roll = state.ThumbSticks.Left.X;
            roll = Math.Sign(roll) * roll * roll;

            float pitch = -state.ThumbSticks.Left.Y;
            pitch = Math.Sign(pitch) * pitch * pitch;

            float yaw = state.ThumbSticks.Right.X;
            yaw = Math.Sign(yaw) * yaw * yaw;

            float gaz = state.ThumbSticks.Right.Y;
            gaz = Math.Sign(gaz) * gaz * gaz;

            if (roll != 0.0f || pitch != 0.0f || yaw != 0.0f || gaz != 0.0f)
                OnProgress(FlightMode.Progressive, roll, pitch, yaw, gaz);
        }
        
        /// <summary>
        /// Process every command that is not movement
        /// </summary>
        /// <param name="state">GamePadState</param>
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
