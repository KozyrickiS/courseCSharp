using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Pizza_Delivery
{
    public class Order
    {
        public delegate void OrderHandler(string message);
        public event OrderHandler AddPizza;
        public event OrderHandler WithdrawPizza;
        public double Price { get; set; }
        public Stack<Pizza> Pizzas { get; set; }

        public Order(double price, Stack<Pizza> pizzas)
        {
            this.Pizzas = pizzas;
            this.Price = price;
        }
        public void Add(Pizza pizza)
        {
            Pizzas.Push(pizza);
            foreach (MenuPrice p in PizzeriaDB.MenuDB())
            {
                if (pizza.Equals(p.pizzaName))
                {
                    Price += p.price;
                    AddPizza?.Invoke($"Pizza {p.pizzaName} added to order with price {p.price}");
                }
            }
        }
        public void Withdraw(Pizza pizza)
        {
            Stack<Pizza> tempPizzas = new Stack<Pizza>();
            int count = Pizzas.Count;
            Pizza p = new Pizza();
            for (int i = 0; i < count; i++)
            {
                p = Pizzas.Pop();
                if (!p.Equals(pizza))
                {
                    tempPizzas.Push(p);
                }
                else
                {
                    foreach (MenuPrice pM in PizzeriaDB.MenuDB())
                    {
                        if (pizza.Equals(pM.pizzaName))
                        {
                            Price -= pM.price;
                            WithdrawPizza?.Invoke($"Pizza {pM.pizzaName} added to order with price {pM.price}");
                        }
                    }
                }
            }
            count = tempPizzas.Count;
            for (int i = 0; i < count; i++)
            {
                Pizzas.Push(tempPizzas.Pop());
            }
        }
    }
}