using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Pizza_Delivery
{
    class PizzaOrder
    {
        double orderPrice = 0.0;
        Stack<Pizza> pizzasStack = new Stack<Pizza>();

        public const string PizzeriaName = "UncleBob";
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

        public void OrderSimulation()
        {
            Order order = new Order(orderPrice, pizzasStack);
            Console.WriteLine($"Welcome to the pizzeria {PizzeriaName}. Introduce youreself, please!");
            Console.WriteLine("Input your lastname:");
            string lastname = Console.ReadLine();
            Console.WriteLine("Input your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Input your midname:");
            string midname = Console.ReadLine();
            Console.WriteLine($"Hello, {name} {midname}.");
            Client client = new Client(lastname, name, midname, null);
            Console.Write($"Today we are ready to recommend you our special share: ");
            ShareAction.Share();
        }
    }
}