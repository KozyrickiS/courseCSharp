using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Air_Simulation
{
    class Baggage
    {
        int weight;
        const int AllowedWeight = 20;
        private string[] _forbiddenBag = new string[] { "drugs", "alcohol", "gasSpray", "ammunition", "toxicSubstance", "sharpObject" };
        public Baggage(int weight)
        {
            if (weight > AllowedWeight)
            {
                Console.WriteLine("The Baggage must be less then 20 kilo");
                Simulation.flagStop = true;
                return;
            }
            else
            {
                this.weight = weight;
            }
        }
        public void CheckBaggage(params string[] bagList)
        {
            for (int i = 0; i < bagList.Length; i++)
            {
                foreach (string forbidden in _forbiddenBag)
                {
                    if (bagList[i].Equals(forbidden))
                    {
                        Console.WriteLine($"{bagList[i]} is forbidden to transport! YOU ARE ARRESTED!!!");
                        Simulation.flagStop = true;
                        return;
                    }
                }
            }
        }
    }
}
