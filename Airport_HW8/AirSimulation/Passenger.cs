using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSimulation
{
    class Passenger
    {
        public string lastname { get; set; }
        public string name { get; set; }
        public string midlname { get; set; }
        public string passwordNumber { get; set; }
        public bool visa { get; set; }
        public Passenger()
        { }
        public Passenger(string lastname, string name, string midlname, string passwordNumber, bool visa)
        {
            this.lastname = lastname;
            this.name = name;
            this.midlname = midlname;
            this.passwordNumber = passwordNumber;
            this.visa = visa;
        }

        public void CheckPass(string passNumb, bool visa)
        {
            if (visa == false)
            {
                Console.WriteLine("You don't have visa. you can't go to another country");
                return;
            }
        }
    }
}
