using AR.Drone.Client.Command;
using System;
using XInputDotNetPure;

namespace MyoPilot.Input
{
    /// <summary>
    /// Input module responsible to process data from the Xbox controller device
    /// </summary>
    public class XBoxInput : Input
    {
        public override void processInput()
        {
            GamePadState state = GamePad.GetState(PlayerIndex.One, GamePadDeadZone.IndependentAxes);
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
        protected void processMovement(GamePadState state)
        {
            float roll = state.ThumbSticks.Left.X;
            roll = (float)Math.Pow(roll, 3);

            float pitch = -state.ThumbSticks.Left.Y;
            pitch = (float)Math.Pow(pitch, 3);

            float yaw = state.ThumbSticks.Right.X;
            yaw = (float)Math.Pow(yaw, 3);

            float gaz = state.ThumbSticks.Right.Y;
            gaz = (float)Math.Pow(gaz, 3);

            if (roll != 0.0f || pitch != 0.0f || yaw != 0.0f || gaz != 0.0f)
                OnProgress(FlightMode.Progressive, roll, pitch, yaw, gaz);
        }
        
        /// <summary>
        /// Process every command that is not movement
        /// </summary>
        /// <param name="state">GamePadState</param>
        protected void processActions(GamePadState state)
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
