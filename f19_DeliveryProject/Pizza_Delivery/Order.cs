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

        public Order(double price, Stack<Pizza> pizzas)
        {
            this.Pizzas = pizzas;
            this.Price = price;
        }
    }
}