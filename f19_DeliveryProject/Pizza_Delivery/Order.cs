using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Pizza_Delivery
{
    public class Order
    {
        public double Price { get; set; }
        public Stack<Pizza> Pizzas { get; set; }

        public Dictionary<double, Pizza> pizzaPrices;
        public Order(double price, Stack<Pizza> pizzas)
        {
            this.Pizzas = pizzas;
            this.Price = price;
            pizzaPrices = new Dictionary<double, Pizza>();
            pizzaPrices.Add(15.11, Pizza.Margherita);
            pizzaPrices.Add(18.33, Pizza.Marinara);
            pizzaPrices.Add(16.81, Pizza.Quattro_Stagioni);
            pizzaPrices.Add(19.36, Pizza.Carbonara);
            pizzaPrices.Add(20.51, Pizza.Frutti_di_Mare);
            pizzaPrices.Add(16.55, Pizza.Quattro_Formaggi);
            pizzaPrices.Add(23.56, Pizza.Crudo);
            pizzaPrices.Add(19.69, Pizza.Napoletana);
            pizzaPrices.Add(18.99, Pizza.Pugliese);
            pizzaPrices.Add(21.32, Pizza.Montanara);
            pizzaPrices.Add(20.05, Pizza.Emiliana);
            pizzaPrices.Add(26.36, Pizza.Romana);
            pizzaPrices.Add(17.54, Pizza.Fattoria);
            pizzaPrices.Add(16.22, Pizza.Schiacciata);
            pizzaPrices.Add(22.23, Pizza.Prosciutto);
            pizzaPrices.Add(20.05, Pizza.Americana);
            pizzaPrices.Add(21.89, Pizza.Prosciutto_e_Funghi);
            pizzaPrices.Add(23.26, Pizza.Braccio_di_Ferro);
            pizzaPrices.Add(25.65, Pizza.Sarda);
            pizzaPrices.Add(26.22, Pizza.Tonno);
            pizzaPrices.Add(19.35, Pizza.Valtellina);
            pizzaPrices.Add(16.96, Pizza.Gorgonzola);
            pizzaPrices.Add(19.65, Pizza.Calzone);
            pizzaPrices.Add(22.64, Pizza.Four_Seasons);
            pizzaPrices.Add(23.65, Pizza.Four_Cheeses);
            pizzaPrices.Add(26.98, Pizza.UncleBobies_Pizza);
        }
    }
}