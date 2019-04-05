using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSimulation
{
    class Simulation
    {
        public const string airportName = "Purgatory";
        public void HelloByTime()
        {
            TimeSpan time = DateTime.Now.TimeOfDay;
            if (time.Hours > 5 && time.Hours < 12)
            {
                Console.Write("Good morning! ");
            }
            else if (time.Hours >= 12 && time.Hours <= 19)
            {
                Console.Write("Good day! ");
            }
            else
            {
                Console.Write("Good evening! ");
            }
            Console.WriteLine($"Welcome to the airport {airportName}. Introduce youreself, please!");

        }

        public void ArportSim()
        {
            Console.WriteLine("Input your lastname:");
            string lastname = Console.ReadLine();
            Console.WriteLine("Input your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Input your midname:");
            string midname = Console.ReadLine();
            Console.WriteLine("Input your password number:");
            string passwordNumber = Console.ReadLine();
            Console.WriteLine("Do you have visa? input \'yes\' or \'no\'");
            string visaAnswer = Console.ReadLine();
            bool visa = false;
            if (visaAnswer.Equals("yes"))
            {
                visa = true;
            }
            Passenger passenger = new Passenger(lastname, name, midname, passwordNumber, visa);
            Console.WriteLine($"Hello, {passenger.name} {passenger.midlname}.");

            Console.WriteLine(" What you what to do? \n1.Buy ticket \n2.Chek in");
            if (int.TryParse(Console.ReadLine(), out int chosenMethod))
            {
                switch (chosenMethod)
                {
                    case 1:
                        {
                            Ticket ticket = new Ticket();
                            string[] ticketToFly = ticket.BuyTicket();
                            break;
                        }
                    case 2:
                        {
                            PassengersDB passengersDB = new PassengersDB();
                            passengersDB.CheckIn();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("This is not a number from 1 to 2!");
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("This is not a number!");
            }
            Console.WriteLine("Please, go through the security");
            Console.WriteLine($"Hello, {passenger.name} {passenger.midlname}. Tell us weight of your luggage, pleaaseee");
            if (int.TryParse(Console.ReadLine(), out int luggageWeight))
            {
                Baggage luggage = new Baggage(luggageWeight);
                luggage.CheckBaggage("eggs", "mobile", "books"/*, "alcohol"*/);
            }
            else
            {
                Console.WriteLine("What a you saying? You must be high! YOU ARE ARRESTED!!!");
                return;
            }
            Console.WriteLine("It's all good. Please, go to the passport control");
            passenger.CheckPass(passenger.passwordNumber, passenger.visa);
            if (passenger.visa == true)
            {
                Console.WriteLine("Passport Control is OK. have a nice flight");
            }

        }
    }
}
