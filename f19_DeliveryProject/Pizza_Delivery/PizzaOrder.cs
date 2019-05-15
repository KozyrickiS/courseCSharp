using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace Pizza_Delivery
{
    class PizzaOrder
    {
        double orderPrice = 0.0;
        Stack<Pizza> pizzasStack = new Stack<Pizza>();
        Order orderForChoose = new Order(0.0, new Stack<Pizza>());

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
            Logger.Log.Info($"Client lastname - {client.Lastname}, name - {client.Name}, midname - {client.Midlname} are created");
            Console.WriteLine("Do you want to order some pizza?  \n1.Yes \n2.No");
            int.TryParse(Console.ReadLine(), out int chosenMethod);
            if (chosenMethod == 2)
            {
                Console.WriteLine("Thank you for visiting UncleBob pizzas");
                Logger.Log.Info($"Client {client.Lastname} {client.Name} start order");
                return;
            }
            else if (chosenMethod != 1 && chosenMethod != 2)
            {
                Logger.Log.Error($"Client {client.Lastname} {client.Name} entered incorrect symbol in start of ordering");
                Console.WriteLine("We don't understand you");
                return;
            }
            Console.Write($"Today we are ready to recommend you our special share: ");
            order = ShareAction.Share();
            Console.WriteLine("What kind of pizza do you want? " +
                "\n1.Enter name of pizza \n2.Choose from the list \n3.Exit");
            int.TryParse(Console.ReadLine(), out int method);
            if (method == 2)
            {
                Logger.Log.Info($"Client {client.Lastname} {client.Name} start choose pizza from list for order");
                Order orderChooseList = ChooseFromList();
                foreach (Pizza element in orderChooseList.Pizzas)
                {
                    order.Pizzas.Push(element);
                }
                order.Price += orderChooseList.Price;
            }
            else if (method == 1)
            {
                Logger.Log.Info($"Client {client.Lastname} {client.Name} start entering pizza for order");
                Order orderChooseName = ChooseByName();
                foreach (Pizza element in orderChooseName.Pizzas)
                {
                    order.Pizzas.Push(element);
                }
                order.Price += orderChooseName.Price;
            }
            else if (method == 3)
            {
                Logger.Log.Info($"Client {client.Lastname} {client.Name} don't order pizza");
                Console.WriteLine("Thank you for visiting UncleBob pizzas");
                return;
            }
            else if (method != 1 && method != 2 && method != 3)
            {
                Logger.Log.Error($"Client {client.Lastname} {client.Name} entered incorrect symbol in choose type of order");
                Console.WriteLine("We don't understand you");
                return;
            }
            Console.Write("List of pizzas in your order: ");
            foreach (Pizza element in order.Pizzas)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("");
            Console.WriteLine($"Price of your order is: {order.Price}");
            Console.WriteLine("Please, tell the address where to deliver the order: ");
            client.HomeAddress = Console.ReadLine();
            Console.WriteLine("Please, tell Email where will be sent information about order status: ");
            string emailaddress = Console.ReadLine();
            try
            {
                client.Email = new MailAddress(emailaddress);
            }
            catch (FormatException)
            {
                Console.WriteLine("This is incorrect email");
                Logger.Log.Error($"Client {client.Lastname} {client.Name} entered incorrect email");
                return;
            }
            client.ClientOrder = order;
            Console.WriteLine("Do you have a discount number? \n1.Yes \n2.No");
            int.TryParse(Console.ReadLine(), out int chosenDiscont);
            if (chosenDiscont == 1)
            {
                Console.WriteLine("Please, input a number of discount");
                int.TryParse(Console.ReadLine(), out int discount);
                client.TakeDiscount(discount);


            }
            Console.WriteLine("That's all, folks");
        }

        private Order ChooseFromList()
        {
            MenuPrice[] menus = PizzeriaDB.MenuDB();
            Console.WriteLine("List of pizzas: ");
            for (int i = 0; i < menus.Length; i++)
            {
                Console.WriteLine($"{menus[i].id}. Pizza {menus[i].pizzaName} - price: {menus[i].price}");
            }
            Console.WriteLine("Input the numbers of pizza's you want to by(like 1 3 5)");
            string numbLine = Console.ReadLine();
            string[] numbsArray = numbLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < numbsArray.Length; i++)
            {
                int.TryParse(numbsArray[i], out int pizzaNumber);
                if (pizzaNumber == 0)
                {
                    Logger.Log.Error($"Client entered incorrect numbers of pizza's in ChooseFromList()");
                }
                foreach (MenuPrice element in menus)
                {
                    if (pizzaNumber == element.id)
                    {
                        orderForChoose.Pizzas.Push(element.pizzaName);
                        orderForChoose.Price += element.price;
                    }
                }
            }
            Logger.Log.Info($"Client end choose pizza from list for order");
            return orderForChoose;
        }

        private Order ChooseByName()
        {
            MenuPrice[] menus = PizzeriaDB.MenuDB();
            Console.WriteLine("Please, enter name of pizza");
            string pizzaName = Console.ReadLine();
            for (int i = 0; i < menus.Length; i++)
            {
                if (pizzaName.Equals(menus[i].pizzaName.ToString()))
                {
                    Console.WriteLine($"Pizza's {menus[i].pizzaName} price is: {menus[i].price}");
                    orderForCoose.Pizzas.Push(menus[i].pizzaName);
                    orderForCoose.Price += menus[i].price;
                }
            }
            Console.WriteLine("Do you want to buy more pizza? \n1.Yes \n2.No");
            int.TryParse(Console.ReadLine(), out int chosenMethod);
            if (chosenMethod == 1)
            {
                ChooseByName();
            }
            if (chosenMethod != 1 && chosenMethod != 2)
            {
                Logger.Log.Error($"Client entered incorrect numbers of action in ChooseByName()");
            }
            Logger.Log.Info($"Client end entering pizza");
            return orderForCoose;
        }
    }
}