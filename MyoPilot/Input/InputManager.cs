using System.Collections.Generic;

namespace MyoPilot.Input
{
    /// <summary>
    /// Container for Input-Elements. Subscribing to events of the InputManager
    /// subscribes to all containing Inputs. The InputManager will raise a
    /// hover event if no containing input has raised an event during processInput()
    /// </summary>
    public class InputManager : Input
    {
        private List<Input> inputs = new List<Input>();
        private bool commandWasSent = false;

        public void addControl(Input input)
        {
            // Redirect the raised events
            input.Emergency += this.OnEmergency;
            input.FlatTrim += this.OnFlatTrim;
            input.Hover += this.OnHover;
            input.Land += this.OnLand;
            input.Progress += this.OnProgress;
            input.Takeoff += this.OnTakeoff;

            // Track if a command was sent during processInput
            input.Emergency += () => commandWasSent = true;
            input.FlatTrim += () => commandWasSent = true;
            input.Hover += () => commandWasSent = true;
            input.Land += () => commandWasSent = true;
            input.Progress += (mode, roll, pitch, yaw, gaz) => commandWasSent = true;
            input.Takeoff += () => commandWasSent = true;

            inputs.Add(input);
        }

        public override void processInput()
        {
            foreach (Input input in inputs)
            {
                input.processInput();
            }

            if (commandWasSent == false)
            {
                OnHover();
            }
            commandWasSent = false;
        }
    }
}
