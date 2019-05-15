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
            Logger.InitLogger();
            Logger.Log.Info($"Start programm {System.Reflection.Assembly.GetEntryAssembly()}");
            PizzaOrder order = new PizzaOrder();
            order.HelloByTime();
            order.OrderSimulation();
            Logger.Log.Info($"Successful completed { System.Reflection.Assembly.GetEntryAssembly()}");

            Console.ReadKey();
        }
    }
}
