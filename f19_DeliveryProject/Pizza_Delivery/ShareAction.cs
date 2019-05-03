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

        public static double Share()
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
        private static double ShareForMonday()
        {
            Console.Write($"pizza {Pizza.Napoletana} for price {PriceForMonday}");
            Console.WriteLine($"Would you like to buy it? \n1.Yes \n2.No");
            int.TryParse(Console.ReadLine(), out int chosenMethod);
            if (chosenMethod == 1)
            {
                Console.WriteLine($"{Pizza.Napoletana} are added to your order. Thank you");
                return PriceForMonday;
            }
            else if (chosenMethod != 1 && chosenMethod != 2)
            {
                Console.WriteLine("We don't understand you. maybe you are want to have an order");
                return 0.0;
            }
            else
            {
                Console.WriteLine("Okay. We are have many various pizza that you can have to order");
                return 0.0;
            }
        }

        private static double ShareForFriday()
        {
            Console.Write($"pizza {Pizza.Calzone} and {Pizza.Four_Cheeses} for special price {PriceForFriday} and get {Pizza.Margherita} for free");
            Console.WriteLine($"Would you like to buy it? \n1.Yes \n2.No");
            int.TryParse(Console.ReadLine(), out int chosenMethod);
            if (chosenMethod == 1)
            {
                Console.WriteLine($"{Pizza.Calzone}, {Pizza.Four_Cheeses} and {Pizza.Margherita}  are added to your order. Thank you");
                return PriceForFriday;
            }
            else if (chosenMethod != 1 && chosenMethod != 2)
            {
                Console.WriteLine("We don't understand you. maybe you are want to have an order");
                return 0.0;
            }
            else
            {
                Console.WriteLine("Okay. We are have many various pizza that you can have to order");
                return 0.0;
            }
        }

        private static double ShareForSaturday()
        {
            Console.Write($"pizza {Pizza.Americana} and {Pizza.Carbonara} for special price {PriceForSaturday}");
            Console.WriteLine($"Would you like to buy it? \n1.Yes \n2.No");
            int.TryParse(Console.ReadLine(), out int chosenMethod);
            if (chosenMethod == 1)
            {
                Console.WriteLine($"{Pizza.Americana} and {Pizza.Carbonara} are added to your order. Thank you");
                return PriceForSaturday;
            }
            else if (chosenMethod != 1 && chosenMethod != 2)
            {
                Console.WriteLine("We don't understand you. maybe you are want to have an order");
                return 0.0;
            }
            else
            {
                Console.WriteLine("Okay. We are have many various pizza that you can have to order");
                return 0.0;
            }
        }

        private static double ShareForElseDays()
        {
            Console.Write($"pizza {Pizza.UncleBobies_Pizza} for special price {PriceForElseDays}");
            Console.WriteLine($"Would you like to buy it? \n1.Yes \n2.No");
            int.TryParse(Console.ReadLine(), out int chosenMethod);
            if (chosenMethod == 1)
            {
                Console.WriteLine($"{Pizza.UncleBobies_Pizza} are added to your order. Thank you");
                return PriceForElseDays;
            }
            else if (chosenMethod != 1 && chosenMethod != 2)
            {
                Console.WriteLine("We don't understand you. maybe you are want to have an order");
                return 0.0;
            }
            else
            {
                Console.WriteLine("Okay. We are have many various pizza that you can have to order");
                return 0.0;
            }
        }
    }
}