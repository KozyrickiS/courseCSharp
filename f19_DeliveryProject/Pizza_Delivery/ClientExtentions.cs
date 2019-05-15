using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Delivery
{
    public static class ClientExtentions
    {
        public const double minPrice = 15.00;
        public static void TakeDiscount(this Client client, int discount)
        {
            Logger.Log.Info($"Start Extentions 'TakeDiscount' for class Client");
            Stack<Discount> disc = PizzeriaDB.DiscountDB();
            foreach (var element in disc)
            {
                if (discount.Equals(element.IdDiscount))
                {
                    if (element.Workability == true)
                    {
                        if (client.ClientOrder.Price < minPrice)
                        {
                            Console.WriteLine($"Sorry, but you can use the discount only if the order amount is from {minPrice}");
                            Logger.Log.Info($"End Extentions 'TakeDiscount' because order price is less then minimalPrice for discount");
                            return;
                        }
                        else
                        {
                            client.ClientOrder.Price -= element.Cash;
                            Console.WriteLine($"Congrats,You got a discount {element.Cash}. \nNow price of your order is: {client.ClientOrder.Price}");
                            element.Workability = false;

                        }
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, but your discount is invalid");
                        Logger.Log.Info($"End Extentions 'TakeDiscount' because discount is invalid");
                        return;
                    }
                }
            }
            Logger.Log.Info($"End Extentions 'TakeDiscount' for class Client");
        }
    }
}
