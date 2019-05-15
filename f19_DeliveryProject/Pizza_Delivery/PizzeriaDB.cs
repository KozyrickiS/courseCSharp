using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Delivery
{
    public static class PizzeriaDB
    {
        public static Stack<Discount> DiscountDB()
        {
            Stack<Discount> discounts = new Stack<Discount>();
            discounts.Push(new Discount() { IdDiscount = 233600, Workability = true, Cash = 5.00 });
            discounts.Push(new Discount() { IdDiscount = 233601, Workability = true, Cash = 3.00 });
            discounts.Push(new Discount() { IdDiscount = 233602, Workability = true, Cash = 4.00 });
            discounts.Push(new Discount() { IdDiscount = 233603, Workability = true, Cash = 6.00 });
            discounts.Push(new Discount() { IdDiscount = 233604, Workability = true, Cash = 5.00 });
            discounts.Push(new Discount() { IdDiscount = 233605, Workability = true, Cash = 7.00 });
            discounts.Push(new Discount() { IdDiscount = 233606, Workability = true, Cash = 2.00 });
            discounts.Push(new Discount() { IdDiscount = 233607, Workability = true, Cash = 4.00 });
            discounts.Push(new Discount() { IdDiscount = 233608, Workability = true, Cash = 4.00 });
            discounts.Push(new Discount() { IdDiscount = 233609, Workability = true, Cash = 5.00 });
            return discounts;
        }
        public static MenuPrice[] MenuDB()
        {
            MenuPrice[] pizzaPrices = new MenuPrice[Enum.GetNames(typeof(Pizza)).Length];
            pizzaPrices[0] = new MenuPrice() { id = (int)Pizza.Margherita, pizzaName = Pizza.Margherita, price = 15.11 };
            pizzaPrices[1] = new MenuPrice() { id = (int)Pizza.Marinara, pizzaName = Pizza.Marinara, price = 18.33 };
            pizzaPrices[2] = new MenuPrice() { id = (int)Pizza.Quattro_Stagioni, pizzaName = Pizza.Quattro_Stagioni, price = 16.81 };
            pizzaPrices[3] = new MenuPrice() { id = (int)Pizza.Carbonara, pizzaName = Pizza.Carbonara, price = 20.51 };
            pizzaPrices[4] = new MenuPrice() { id = (int)Pizza.Frutti_di_Mare, pizzaName = Pizza.Frutti_di_Mare, price = 19.36 };
            pizzaPrices[5] = new MenuPrice() { id = (int)Pizza.Quattro_Formaggi, pizzaName = Pizza.Quattro_Formaggi, price = 16.55 };
            pizzaPrices[6] = new MenuPrice() { id = (int)Pizza.Crudo, pizzaName = Pizza.Crudo, price = 23.56 };
            pizzaPrices[7] = new MenuPrice() { id = (int)Pizza.Napoletana, pizzaName = Pizza.Napoletana, price = 19.69 };
            pizzaPrices[8] = new MenuPrice() { id = (int)Pizza.Pugliese, pizzaName = Pizza.Pugliese, price = 18.99 };
            pizzaPrices[9] = new MenuPrice() { id = (int)Pizza.Montanara, pizzaName = Pizza.Montanara, price = 21.32 };
            pizzaPrices[10] = new MenuPrice() { id = (int)Pizza.Emiliana, pizzaName = Pizza.Emiliana, price = 20.05 };
            pizzaPrices[11] = new MenuPrice() { id = (int)Pizza.Romana, pizzaName = Pizza.Romana, price = 26.36 };
            pizzaPrices[12] = new MenuPrice() { id = (int)Pizza.Fattoria, pizzaName = Pizza.Fattoria, price = 17.54 };
            pizzaPrices[13] = new MenuPrice() { id = (int)Pizza.Schiacciata, pizzaName = Pizza.Schiacciata, price = 16.22 };
            pizzaPrices[14] = new MenuPrice() { id = (int)Pizza.Prosciutto, pizzaName = Pizza.Prosciutto, price = 22.23 };
            pizzaPrices[15] = new MenuPrice() { id = (int)Pizza.Americana, pizzaName = Pizza.Americana, price = 20.06 };
            pizzaPrices[16] = new MenuPrice() { id = (int)Pizza.Prosciutto_e_Funghi, pizzaName = Pizza.Prosciutto_e_Funghi, price = 21.89 };
            pizzaPrices[17] = new MenuPrice() { id = (int)Pizza.Braccio_di_Ferro, pizzaName = Pizza.Braccio_di_Ferro, price = 23.26 };
            pizzaPrices[18] = new MenuPrice() { id = (int)Pizza.Sarda, pizzaName = Pizza.Sarda, price = 25.65 };
            pizzaPrices[19] = new MenuPrice() { id = (int)Pizza.Tonno, pizzaName = Pizza.Tonno, price = 26.22 };
            pizzaPrices[20] = new MenuPrice() { id = (int)Pizza.Valtellina, pizzaName = Pizza.Valtellina, price = 19.35 };
            pizzaPrices[21] = new MenuPrice() { id = (int)Pizza.Gorgonzola, pizzaName = Pizza.Gorgonzola, price = 16.96 };
            pizzaPrices[22] = new MenuPrice() { id = (int)Pizza.Calzone, pizzaName = Pizza.Calzone, price = 19.65 };
            pizzaPrices[23] = new MenuPrice() { id = (int)Pizza.Four_Seasons, pizzaName = Pizza.Four_Seasons, price = 22.64 };
            pizzaPrices[24] = new MenuPrice() { id = (int)Pizza.Four_Cheeses, pizzaName = Pizza.Four_Cheeses, price = 23.65 };
            pizzaPrices[25] = new MenuPrice() { id = (int)Pizza.UncleBobies_Pizza, pizzaName = Pizza.UncleBobies_Pizza, price = 26.98 };
            return pizzaPrices;
        }
    }
}
