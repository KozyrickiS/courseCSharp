using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Air_Simulation
{
    class Ticket
    {
        private int count;
        public string[] tickets { get; set; }
        public Flight flight { get; set; }

        public Ticket()
        { }
        public Ticket(string[] tickets, Flight flight)
        {
            this.tickets = tickets;
            this.flight = flight;
        }

        public Ticket BuyTicket(string destiny, int count)
        {
            Flight flight = new Flight();
            flight.ChooseFlight(destiny);
            string[] tickets = new string[count];
            if (destiny != null)
            {
                for (int i = 0; i < tickets.Length; i++)
                {
                    tickets[i] = destiny + i;
                }
            }
            else
            {
                Console.WriteLine("We don't fly on this destination. We are deeply sorry!");
                Simulation.flagStop = true;
            }
            Ticket ticket = new Ticket(tickets, flight);
            return ticket;
        }
    }
}
