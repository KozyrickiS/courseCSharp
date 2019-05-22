using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pizza_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.InitLogger();
            Logger.Log.Info($"Start programm {System.Reflection.Assembly.GetEntryAssembly()}");
            HelloMessage hello = new HelloMessage();
            hello.ByTime();
            PizzaOrder order = new PizzaOrder();
            Thread orderThread = new Thread(new ThreadStart(order.OrderSimulation));
            orderThread.Name = "Thread " + order.ToString();
            Logger.Log.Info($"Start Thread  '{orderThread.Name}'");
            orderThread.Start();          
            Logger.Log.Info($"Successful completed { System.Reflection.Assembly.GetEntryAssembly()}");
            Console.ReadKey();
        }
    }
}
