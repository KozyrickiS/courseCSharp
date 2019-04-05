using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSimulation
{
    class Baggage
    {
        int weight;
        public Baggage(int weight)
        {
            if (weight > 20)
            {
                Console.WriteLine("The Baggage must be less then 20 kilo");
                return;
            }
            else
            this.weight = weight;
        }
        public void CheckBaggage(params string[] bagList)
        {
            for (int i = 0; i < bagList.Length; i++)
            {
                if (bagList[i].Equals("drugs") || bagList[i].Equals("alcohol"))
                {
                    Console.WriteLine("These things are forbidden to transport! YOU ARE ARRESTED!!!");
                    return;
                }
            }
        }
    }
}
