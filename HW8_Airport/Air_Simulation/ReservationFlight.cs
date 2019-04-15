using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Air_Simulation
{
    class ReservationFlight : Flight
    {
        public string passengerLastname { get; set; }
        public string ticketID { get; set; }
        public bool needVisa { get; set; }
        public ReservationFlight()
        { }
        public ReservationFlight(string passengerLastname, string placeDestination, string ticketID)
        {
            this.passengerLastname = passengerLastname;
            this.placeDestination = placeDestination;
            this.ticketID = ticketID;
        }
        public ReservationFlight(string passengerLastname, string placeDeparture, string placeDestination, string ticketID)
        {
            this.passengerLastname = passengerLastname;
            this.placeDeparture = placeDeparture;
            this.placeDestination = placeDestination;
            this.ticketID = ticketID;
        }

        public ReservationFlight CheckIn()
        {
            ReservationFlight reserve1 = new ReservationFlight("Kinchev", destinyCity[0], "666");
            ReservationFlight reserve2 = new ReservationFlight("Chizh", destinyCity[1], "667");
            ReservationFlight reserve3 = new ReservationFlight("Chevchuk", destinyCity[2], "668");
            ReservationFlight reserve4 = new ReservationFlight("Butusov", destinyCity[3], "669");
            ReservationFlight reserve5 = new ReservationFlight("Shkliarski", destinyCity[4], "670");
            ReservationFlight reserve6 = new ReservationFlight("Samoilov", destinyCity[1], "671");
            ReservationFlight reserve7 = new ReservationFlight("Dolnik", PlaceAirport, destinyCity[0], "672");
            List<ReservationFlight> reserveList = new List<ReservationFlight>();
            reserveList.Add(reserve1);
            reserveList.Add(reserve2);
            reserveList.Add(reserve3);
            reserveList.Add(reserve4);
            reserveList.Add(reserve5);
            reserveList.Add(reserve6);
            reserveList.Add(reserve7);
            ReservationFlight reservePassenger = new ReservationFlight();

            Console.WriteLine("Hello. Input the number of ticket reservation?");
            string ticketRes = Console.ReadLine();
            foreach (ReservationFlight reserve in reserveList)
            {
                if (ticketRes.Equals(reserve.ticketID))
                {
                    reservePassenger = reserve;
                }
            }
            if (reservePassenger.ticketID == null)
            {
                Console.WriteLine("This flight does not exist");
                Simulation.flagStop = true;
                return null;
            }

            Console.WriteLine("Input the flight where are you going");
            string destiny = Console.ReadLine();
            if (!destiny.Equals(reservePassenger.placeDestination))
            {
                Console.WriteLine("Wrong destination");
                Simulation.flagStop = true;
                return null;
            }
            for (int i = 0; i < visaCity.Length; i++)
            {
                if (destiny.Equals(visaCity[i]))
                {
                    needVisa = true;
                }
            }

            /*
            Console.WriteLine("How many tickets you have?");
            int.TryParse(Console.ReadLine(), out int count);
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"For {i}- ticket input ticket number");
                string ticketnumb = Console.ReadLine();
                if (!ticketnumb.Equals(reservePassenger.ticketID))
                {
                    Console.WriteLine("Wrong ticket");
                    Simulation.flagStop = true;
                    return;
                }
            }*/

            Console.WriteLine("Input your lastname");
            string lnamePas = Console.ReadLine();
            if (!lnamePas.Equals(reservePassenger.passengerLastname))
            {
                Console.WriteLine("Wrong lastname");
                Simulation.flagStop = true;
                return null;
            }
            Console.WriteLine("Thank you for chek in your ticket");
            return reservePassenger;
        }
    }
}
