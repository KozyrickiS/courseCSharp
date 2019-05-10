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
            Client client = new Client(lastname, name, midname);
            Console.Write($"Today we are ready to recommend you our special share: ");
            order = ShareAction.Share();
            Console.WriteLine("Do you want to order some pizza?  \n1.Yes \n2.No");
            int.TryParse(Console.ReadLine(), out int chosenMethod);
            if (chosenMethod == 2)
            {
                Console.WriteLine("Thank you for visiting UncleBob pizzas");
                return;
            }
            else if (chosenMethod != 1 && chosenMethod != 2)
            {
                Console.WriteLine("We don't understand you");
                return;
            }
            Console.WriteLine("What kind of pizza do you want? " +
                "\n1.Enter name of pizza \n2.Choose from the list");
            int.TryParse(Console.ReadLine(), out int method);
            if (method == 2)
            {
                foreach (KeyValuePair<double, Pizza> keyValue in order.pizzaPrices)
                {
                    Console.WriteLine($"Pizza {keyValue.Value} - price: {keyValue.Key}");
                }
            }
            else if (method == 1)
            {
                Console.WriteLine("Please, enter name of pizza");
                string pizzaName = Console.ReadLine();
                foreach (KeyValuePair<double, Pizza> keyValue in order.pizzaPrices)
                {
                    if (pizzaName.Equals(keyValue.Value.ToString()))
                    {
                        Console.WriteLine($"Pizza's {keyValue.Value} price is: {keyValue.Key}");
                    }
                }
            }
            else if (method != 1 && method != 2)
            {
                Console.WriteLine("We don't understand you");
                return;
            }

        }
    }
}