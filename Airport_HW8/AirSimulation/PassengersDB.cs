using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSimulation
{
    class PassengersDB
    {
        public string passengerLastname { get; set; }
        public string passengerName { get; set; }
        public string passengerMidlname { get; set; }
        public string passengerPassword { get; set; }
        public string airflightID { get; set; }
        public string placeDeparture { get; set; }
        public string placeDestination { get; set; }
        public string ticketID { get; set; }
        public PassengersDB(string passengerLastname, string passengerName, string passengerMidlname, string passengerPassword,
            string airflightID, string placeDeparture, string placeDestination, string ticketID)
        {
            this.passengerLastname = passengerLastname;
            this.passengerName = passengerName;
            this.passengerMidlname = passengerMidlname;
            this.passengerPassword = passengerPassword;
            this.airflightID = airflightID;
            this.placeDeparture = placeDeparture;
            this.placeDestination = placeDestination;
            this.ticketID = ticketID;
        }
        public PassengersDB()
        { }

        public void CheckIn()
        {
            PassengersDB dB1 = new PassengersDB("a", "a", "a", "111", "1", "Minsk", "Moskow", "666");
            PassengersDB dB2 = new PassengersDB("b", "b", "b", "222", "2", "Minsk", "London", "667");
            PassengersDB dB3 = new PassengersDB("c", "c", "c", "333", "3", "Minsk", "Paris", "668");
            PassengersDB dB4 = new PassengersDB("d", "d", "d", "444", "4", "Minsk", "NewYork", "669");
            PassengersDB dB5 = new PassengersDB("e", "e", "e", "555", "5", "Minsk", "Zhabinka", "670");
            List<PassengersDB> dBs = new List<PassengersDB>();
            dBs.Add(dB1);
            dBs.Add(dB2);
            dBs.Add(dB3);
            dBs.Add(dB4);
            dBs.Add(dB5);
            PassengersDB passengersDB = new PassengersDB();
            Console.WriteLine("Hello. Input the flight where are you going");
            string destiny = Console.ReadLine();
            foreach (PassengersDB dB in dBs)
            {
                if (destiny.Equals(dB.placeDestination))
                {
                    passengersDB = dB;
                }
            }
            if (passengersDB.ticketID == null)
            {
                Console.WriteLine("This flight does not exist");
                return;
            }
            Console.WriteLine("Input your ticket number");
            string ticketnumb = Console.ReadLine();
            if (!ticketnumb.Equals(passengersDB.ticketID))
            {
                Console.WriteLine("Wrong ticket");
                return;
            }
            Console.WriteLine("Input your lastname");
            string lnamePas = Console.ReadLine();
            if (!lnamePas.Equals(passengersDB.passengerLastname))
            {
                Console.WriteLine("Wrong lastname");
                return;
            }
            Console.WriteLine("Thank you for chek in your ticket");
        }
    }
}
