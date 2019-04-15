using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Air_Simulation
{
    class Passenger
    {
        public string lastname { get; set; }
        public string name { get; set; }
        public string midlname { get; set; }
        public string passportNumber { get; set; }
        public bool visa { get; set; }
        private string[] criminalPassports = new string[] { "МС1212121", "МС1212122", "МС1212123" };
        public Passenger()
        { }
        public Passenger(string lastname, string name, string midlname, bool visa)
        {
            this.lastname = lastname;
            this.name = name;
            this.midlname = midlname;
            this.visa = visa;
        }
        public Passenger(string passportNumber, bool visa)
        {
            this.passportNumber = passportNumber;
            this.visa = visa;
        }
        public void CheckPaspVisa(string passportNumber)
        {
            for (int i = 0; i < criminalPassports.Length; i++)
            {
                if (passportNumber.Equals(criminalPassports[i]))
                {
                    Console.WriteLine("YOU ARE ARRESTED!!!");
                    Simulation.flagStop = true;
                    return;
                }
            }
        }
        public void CheckPaspVisa(string passportNumber, bool visa)
        {
            if (visa == false)
            {
                Console.WriteLine("You don't have visa. You can't fly this flight. Sorry");
                Simulation.flagStop = true;
                return;
            }
            CheckPaspVisa(passportNumber);
        }
    }
}
