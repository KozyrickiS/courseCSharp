using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSimulation
{
    class Ticket
    {
        private int count = 0;
        public string ticketID { get; set; }
        public string airflightID { get; set; }
        public string[] BuyTicket()
        {
            AirFlight MinskMoskow = new AirFlight("1", "Minsk", "Moskow");
            AirFlight MinskLondon = new AirFlight("2", "Minsk", "London");
            AirFlight MinskParis = new AirFlight("3", "Minsk", "Paris");
            AirFlight MinskNewyork = new AirFlight("4", "Minsk", "NewYork");
            AirFlight MinskZhabinka = new AirFlight("5", "Minsk", "Zhabinka");
            List<AirFlight> airFlights = new List<AirFlight>();
            airFlights.Add(MinskMoskow);
            airFlights.Add(MinskLondon);
            airFlights.Add(MinskParis);
            airFlights.Add(MinskNewyork);
            airFlights.Add(MinskZhabinka);

            Console.WriteLine("What Destination you whant to go?");
            string destiny = Console.ReadLine();
            AirFlight air = new AirFlight();
            foreach (AirFlight airFlight in airFlights)
            {
                if (airFlight.placeDestination.Equals(destiny))
                {
                    air = airFlight;
                }
            }
            this.airflightID = air.airflightID;
            this.ticketID = Convert.ToString(count);
            count++;
            Console.WriteLine($"You buy a ticket to the airplane \"{air.placeDeparture} - {air.placeDestination}\". Number of your ticket is {ticketID}. Please, go to chek in");
            return new string[] { ticketID, airflightID };
        }
    }
}
