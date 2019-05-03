using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaOrder order = new PizzaOrder();
            order.HelloByTime();
            order.OrderSimulation();

            Console.ReadKey();
        }
    }
}
