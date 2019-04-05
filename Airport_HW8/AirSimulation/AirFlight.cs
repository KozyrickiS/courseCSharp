using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSimulation
{
    class AirFlight
    {
        public string airflightID { get; set; }
        public string placeDeparture { get; set; }
        public string placeDestination { get; set; }
        //DateTime departureTime { get; set; }
        //DateTime arrivalTime { get; set; }
        public AirFlight()
        {
        }
        public AirFlight(string airflightID)
        {
            this.airflightID = airflightID;
        }
        public AirFlight(string placeDeparture, string placeDestination)
        {
            this.placeDeparture = placeDeparture;
            this.placeDestination = placeDestination;
        }
        public AirFlight(string airflightID, string placeDeparture, string placeDestination)
        {
            this.airflightID = airflightID;
            this.placeDeparture = placeDeparture;
            this.placeDestination = placeDestination;
        }
    }
}
