using AR.Drone.Client.Command;

namespace MyoPilot.Input
{
    public delegate void NoArgs();
    public delegate void FlightCommand(FlightMode mode, float roll = 0, float pitch = 0, float yaw = 0, float gaz = 0);

    /// <summary>
    /// The Input class defines all possible input events. Generation of these events should occur within 
    /// the processInput method of classes inheriting Input
    /// </summary>
    public abstract class Input
    {
        // Events correspond to available actions in AR.Drone.Client.DroneClient
        public event NoArgs Emergency;
        public event NoArgs Land;
        public event NoArgs Takeoff;
        public event NoArgs FlatTrim;
        public event NoArgs Hover;
        public event FlightCommand Progress;

        /// <summary>
        /// Implementors of this Class should process the state of the
        /// peripheral (e.g. keyboard, mouse) and raise events to trigger 
        /// actions. This method schould be invoked periodically via a Timer in the main Form
        /// </summary>
        public abstract void processInput();

        #region .Methods for Triggering the events.
        protected void OnEmergency()
        {
            if (Emergency != null)
                Emergency();
        }

        protected void OnLand()
        {
            if (Land != null)
                Land();
        }

        protected void OnTakeoff()
        {
            if (Takeoff != null)
                Takeoff();
        }

        protected void OnFlatTrim()
        {
            if (FlatTrim != null)
                FlatTrim();
        }

        protected void OnHover()
        {
            if (Hover != null)
                Hover();
        }

        protected void OnProgress(FlightMode mode, float roll = 0, float pitch = 0, float yaw = 0, float gaz = 0)
        {
            if (Emergency != null)
                Progress(mode, roll, pitch, yaw, gaz);
        }
        #endregion
    }
}
