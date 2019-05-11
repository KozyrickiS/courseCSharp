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

        Order orderForCoose = new Order(0.0, new Stack<Pizza>());
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
                Order orderChooseList = ChooseFromList();
                foreach (Pizza element in orderChooseList.Pizzas)
                {
                    order.Pizzas.Push(element);
                }
                order.Price += orderChooseList.Price;
            }
            else if (method == 1)
            {
                Order orderChooseName = ChooseByName();
                foreach (Pizza element in orderChooseName.Pizzas)
                {
                    order.Pizzas.Push(element);
                }
                order.Price += orderChooseName.Price;
            }
            else if (method != 1 && method != 2)
            {
                Console.WriteLine("We don't understand you");
                return;
            }
            Console.WriteLine("List of pizzas: ");
        }

        private Order ChooseFromList()
        {
            Order order = new Order(orderPrice, pizzasStack);
            Console.WriteLine("List of pizzas: ");
            for (int i = 0; i < order.pizzaPrices.Length; i++)
            {
                Console.WriteLine($"{order.pizzaPrices[i].id}. Pizza {order.pizzaPrices[i].pizzaName} - price: {order.pizzaPrices[i].price}");
            }
            Console.WriteLine("Input the numbers of pizza's you want to by(like 1 3 5)");
            string numbLine = Console.ReadLine();
            string[] numbsArray = numbLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < numbsArray.Length; i++)
            {
                int.TryParse(numbsArray[i], out int pizzaNumber);
                foreach (MenuPrice element in order.pizzaPrices)
                {
                    if (pizzaNumber == element.id)
                    {
                        order.Pizzas.Push(element.pizzaName);
                        order.Price += element.price;
                    }
                }
            }
            return order;
        }

        private Order ChooseByName()
        {
            Console.WriteLine("Please, enter name of pizza");
            string pizzaName = Console.ReadLine();
            for (int i = 0; i < orderForCoose.pizzaPrices.Length; i++)
            {
                if (pizzaName.Equals(orderForCoose.pizzaPrices[i].pizzaName.ToString()))
                {
                    Console.WriteLine($"Pizza's {orderForCoose.pizzaPrices[i].pizzaName} price is: {orderForCoose.pizzaPrices[i].price}");
                    orderForCoose.Pizzas.Push(orderForCoose.pizzaPrices[i].pizzaName);
                    orderForCoose.Price += orderForCoose.pizzaPrices[i].price;
                }
            }
            Console.WriteLine("Do you want to buy more pizza? \n1.Yes \n2.No");
            int.TryParse(Console.ReadLine(), out int chosenMethod);
            if (chosenMethod == 1)
            {
                ChooseByName();
            }
            return orderForCoose;
        }
    }
}