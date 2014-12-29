using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyoPilot.Input
{
    /// <summary>
    /// Container 
    /// </summary>
    class InputManager : Input
    {
        public event NoArgs Emergency;
        public event NoArgs Land;
        public event NoArgs Takeoff;
        public event NoArgs FlatTrim;
        public event NoArgs Hover;
        public event FlightCommand Progress;

        public void processInput()
        {
            throw new NotImplementedException();
        }
    }
}
