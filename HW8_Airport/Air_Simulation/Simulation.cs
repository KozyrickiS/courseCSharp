using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Air_Simulation
{
    class Simulation
    {
        public const string AirportName = "Purgatory";
        public static bool flagStop = false;
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
        }

        public void ArportSim()
        {
            Console.WriteLine($"Welcome to the airport {AirportName}. Introduce youreself, please!");
            Console.WriteLine("Input your lastname:");
            string lastname = Console.ReadLine();
            Console.WriteLine("Input your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Input your midname:");
            string midname = Console.ReadLine();
            Console.WriteLine($"Hello, {name} {midname}.");
            Console.WriteLine("Do you have visa? input \'yes\' or \'no\'");
            string visaAnswer = Console.ReadLine();
            bool visa = false;
            if (visaAnswer.Equals("yes"))
            {
                visa = true;
            }
            Passenger passenger = new Passenger(lastname, name, midname, visa);
            Console.WriteLine(" Do you have a ticket? \n1.No, I want to buy a ticket \n2.Yes, I want to Chek in");
            int.TryParse(Console.ReadLine(), out int chosenMethod);
            if (chosenMethod == 1)
            {
                Console.WriteLine("What Destination you whant to go?");
                string destiny = Console.ReadLine();
                Console.WriteLine("How many tickets you want to buy?");
                int.TryParse(Console.ReadLine(), out int count);
                Ticket ticket = new Ticket();
                ticket = ticket.BuyTicket(destiny, count);
                if (flagStop == true)
                { return; }
                Console.WriteLine("Thank you for buying a tickets. Go to check in");
            }
            else if (chosenMethod != 1 && chosenMethod != 2)
            {
                Console.WriteLine("Maybe you came the wrong address. Get out!");
                return;
            }

            ReservationFlight checkPassenger = new ReservationFlight();
            checkPassenger = checkPassenger.CheckIn();
            if ((flagStop == true) || checkPassenger == null)
            { return; }

            Console.WriteLine("Please, go through the security");
            Console.WriteLine($"Hello, {passenger.name} {passenger.midlname}. Tell us weight of your luggage, pleaaseee");
            if (int.TryParse(Console.ReadLine(), out int luggageWeight))
            {
                Baggage luggage = new Baggage(luggageWeight);
                if (flagStop == true)
                { return; }
                //luggage.CheckBaggage("eggs", "mobile", "books", "alcohol");
                Console.WriteLine("Tell us, please, what's in your baggage?(write the answer through the spase, like: eggs mobile book)");
                string luggageLine = Console.ReadLine();
                string[] luggageArray = luggageLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                luggage.CheckBaggage(luggageArray);
                if (flagStop == true)
                { return; }
            }
            else
            {
                Console.WriteLine("What a you saying? You must be high! YOU ARE ARRESTED!!!");
                return;
            }
            Console.WriteLine("It's all good. Please, go to the passport control");

            Console.WriteLine("Hello, can you give us a passport, we will check you on Database");
            Console.WriteLine("Input your passport number:");
            passenger.passportNumber = Console.ReadLine();
            Console.Write($"Oh, I see you are going to {checkPassenger.placeDestination}. To fly to this city ");
            if (checkPassenger.needVisa == true)
            {
                Console.WriteLine("you need to have a visa");
                passenger.CheckPaspVisa(passenger.passportNumber, passenger.visa);
            }
            else
            {
                Console.WriteLine("you don't need to have a visa");
                passenger.CheckPaspVisa(passenger.passportNumber);
            }
            if (flagStop == true)
            { return; }
            Console.WriteLine("Passport Control is OK. have a nice flight");
        }
    }
}
