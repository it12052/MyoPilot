using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AR.Drone.Client.Command;

namespace MyoPilot.Input
{
    public delegate void NoArgs();
    public delegate void FlightCommand(FlightMode mode, float roll = 0, float pitch = 0, float yaw = 0, float gaz = 0);

    public abstract class Input
    {
        // Events correspond to available actions in AR.Drone.Client.DroneClient
        event NoArgs Emergency;
        //event NoArgs ResetEmergency; // This can be done in the MainForm
        event NoArgs Land;
        event NoArgs Takeoff;
        event NoArgs FlatTrim;
        event NoArgs Hover;
        event FlightCommand Progress;

        /// <summary>
        /// Implementors of this Class should process the state of the
        /// peripheral (e.g. keyboard, mouse) and raise events to trigger 
        /// actions. This method schould be invoked periodically via a Timer
        /// </summary>
        abstract void processInput();

        void OnEmergency()
        {
            if (Emergency != null)
                Emergency();
        }

        void OnLand()
        {
            if (Land != null)
                Land();
        }

        void OnTakeoff()
        {
            if (Takeoff != null)
                Takeoff();
        }

        void OnFlatTrim()
        {
            if (FlatTrim != null)
                FlatTrim();
        }

        void OnHover()
        {
            if (Hover != null)
                Hover();
        }

        void OnProgress(FlightMode mode, float roll = 0, float pitch = 0, float yaw = 0, float gaz = 0)
        {
            if (Emergency != null)
                Progress(mode, roll, pitch, yaw, gaz);
        }
    }
}
