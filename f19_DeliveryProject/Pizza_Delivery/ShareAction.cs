using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Pizza_Delivery
{
    public static class ShareAction
    {
        private const double PriceForMonday = 9.99;
        private const double PriceForFriday = 24.99;
        private const double PriceForSaturday = 19.99;
        private const double PriceForElseDays = 13.99;

        public static Order Share()
        {
            DayOfWeek dayOfWeek = DateTime.Now.DayOfWeek;
            if (dayOfWeek.Equals(DayOfWeek.Monday))
            {
                return ShareForMonday();
            }
            else if (dayOfWeek.Equals(DayOfWeek.Friday))
            {
                return ShareForFriday();
            }
            else if (dayOfWeek.Equals(DayOfWeek.Saturday))
            {
                return ShareForSaturday();
            }
            else
            {
                return ShareForElseDays();
            }
        }
        private static Order ShareForMonday()
        {
            Logger.Log.Info($"Start share action 'ShareForMonday'");
            Stack<Pizza> pizzas = new Stack<Pizza>();
            Order shareOrder = new Order(0.0, pizzas);
            Console.Write($"pizza {Pizza.Napoletana} for price {PriceForMonday}");
            Console.WriteLine($"Would you like to buy it? \n1.Yes \n2.No");
            int.TryParse(Console.ReadLine(), out int chosenMethod);
            if (chosenMethod == 1)
            {
                Console.WriteLine($"{Pizza.Napoletana} are added to your order. Thank you");
                shareOrder.Pizzas.Push(Pizza.Napoletana);
                shareOrder.Price = PriceForMonday;
            }
            else if (chosenMethod == 2)
            {
                Console.WriteLine("Okay. We are have many various pizza that you can have to order");
            }
            else
            {
                Logger.Log.Error($"In 'ShareForMonday' incorrect number of chosen method");
                Console.WriteLine("We don't understand you. maybe you are want to have an order");
            }
            Logger.Log.Info($"End share action 'ShareForMonday'");
            return shareOrder;
        }

        private static Order ShareForFriday()
        {
            Logger.Log.Info($"Start share action 'ShareForFriday'");
            Stack<Pizza> pizzas = new Stack<Pizza>();
            Order shareOrder = new Order(0.0, pizzas);
            Console.Write($"pizza {Pizza.Calzone} and {Pizza.Four_Cheeses} for special price {PriceForFriday} and get {Pizza.Margherita} for free");
            Console.WriteLine($"Would you like to buy it? \n1.Yes \n2.No");
            int.TryParse(Console.ReadLine(), out int chosenMethod);
            if (chosenMethod == 1)
            {
                Console.WriteLine($"{Pizza.Calzone}, {Pizza.Four_Cheeses} and {Pizza.Margherita}  are added to your order. Thank you");
                shareOrder.Pizzas.Push(Pizza.Calzone);
                shareOrder.Pizzas.Push(Pizza.Four_Cheeses);
                shareOrder.Pizzas.Push(Pizza.Margherita);
                shareOrder.Price = PriceForFriday;
            }
            else if (chosenMethod == 2)
            {
                Console.WriteLine("Okay. We are have many various pizza that you can have to order");
            }
            else
            {
                Logger.Log.Error($"In 'ShareForFriday' incorrect number of chosen method");
                Console.WriteLine("We don't understand you. maybe you are want to have an order");
            }
            Logger.Log.Info($"End share action 'ShareForFriday'");
            return shareOrder;
        }

        private static Order ShareForSaturday()
        {
            Logger.Log.Info($"Start share action 'ShareForSaturday'");
            Stack<Pizza> pizzas = new Stack<Pizza>();
            Order shareOrder = new Order(0.0, pizzas);
            Console.Write($"pizza {Pizza.Americana} and {Pizza.Carbonara} for special price {PriceForSaturday}");
            Console.WriteLine($"Would you like to buy it? \n1.Yes \n2.No");
            int.TryParse(Console.ReadLine(), out int chosenMethod);
            if (chosenMethod == 1)
            {
                Console.WriteLine($"{Pizza.Americana} and {Pizza.Carbonara} are added to your order. Thank you");
                shareOrder.Pizzas.Push(Pizza.Americana);
                shareOrder.Pizzas.Push(Pizza.Carbonara);
                shareOrder.Price = PriceForSaturday;
            }
            else if (chosenMethod == 2)
            {
                Console.WriteLine("Okay. We are have many various pizza that you can have to order");
            }
            else
            {
                Logger.Log.Error($"In 'ShareForSaturday' incorrect number of chosen method");
                Console.WriteLine("We don't understand you. maybe you are want to have an order");
            }
            Logger.Log.Info($"End share action 'ShareForSaturday'");
            return shareOrder;
        }

        private static Order ShareForElseDays()
        {
            Logger.Log.Info($"Start share action 'ShareForElseDays'");
            Stack<Pizza> pizzas = new Stack<Pizza>();
            Order shareOrder = new Order(0.0, pizzas);
            Console.Write($"pizza {Pizza.UncleBobies_Pizza} for special price {PriceForElseDays}");
            Console.WriteLine($"Would you like to buy it? \n1.Yes \n2.No");
            int.TryParse(Console.ReadLine(), out int chosenMethod);
            if (chosenMethod == 1)
            {
                Console.WriteLine($"{Pizza.UncleBobies_Pizza} are added to your order. Thank you");
                shareOrder.Pizzas.Push(Pizza.UncleBobies_Pizza);
                shareOrder.Price = PriceForElseDays;
            }
            else if (chosenMethod == 2)
            {
                Console.WriteLine("Okay. We are have many various pizza that you can have to order");
            }
            else
            {
                Logger.Log.Error($"In 'ShareForElseDays' incorrect number of chosen method");
                Console.WriteLine("We don't understand you. maybe you are want to have an order");
            }
            Logger.Log.Info($"End share action 'ShareForElseDays'");
            return shareOrder;
        }
    }
}