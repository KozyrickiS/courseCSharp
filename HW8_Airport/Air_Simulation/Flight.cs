using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Air_Simulation
{
    class Flight
    {
        public const string placeAirport = "Minsk";
        public string placeDeparture { get; set; }
        public string placeDestination { get; set; }

        public string[] destinyCity = new string[] { "Moskow", "London", "Paris", "NewYork", "Zhabinka" };
        public string[] visaCity = new string[] { "London", "Paris", "NewYork" };
        public Flight()
        {
        }
        public Flight(string placeDeparture, string placeDestination)
        {
            this.placeDeparture = placeDeparture;
            this.placeDestination = placeDestination;
        }
        public Flight(string placeDestination)
        {
            this.placeDeparture = placeAirport;
            this.placeDestination = placeDestination;
        }
        public Flight ChooseFlight(string destiny)
        {
            Flight air = new Flight();
            foreach (string dest in destinyCity)
            {
                if (destiny.Equals(dest))
                {
                    air.placeDestination = destiny;
                    air.placeDeparture = placeAirport;
                }
            }
            return air;
        }
    }
}
