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

        /// <summary>
        /// Add an input module to the input manager. Output from this module is aggregated with 
        /// all other modules registered to the input manager. The input manager will start to 
        /// schedule calculation time via calls to processInput()
        /// </summary>
        /// <param name="input">input module to manage</param>
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

        /// <summary>
        /// Instructs all managed input modules to process their associated input device
        /// and generate commands. Should be called regularly
        /// </summary>
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
