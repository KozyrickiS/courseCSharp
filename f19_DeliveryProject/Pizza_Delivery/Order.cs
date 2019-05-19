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
        public void Check()
        {
            Console.WriteLine("Your order is:");
            int number = 1;
            foreach (Pizza pizza in Pizzas)
            {
                Console.WriteLine($"{number}. {pizza}");
                number++;
            }
            Console.WriteLine($"Order price: {Price}");
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
        public void Withdraw(string pizzaNumbers)
        {
            Stack<Pizza> deletePizzas = new Stack<Pizza>();
            string[] numbsArray = pizzaNumbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);            
            for (int i = 0; i < numbsArray.Length; i++)
            {
                int.TryParse(numbsArray[i], out int pizzaNumb);
                int number = 1;
                foreach (Pizza pizza in Pizzas)
                {
                    if (number == pizzaNumb)
                    {
                        deletePizzas.Push(pizza);
                    }
                    number++;
                }
            }
            Stack<Pizza> tempPizzas = new Stack<Pizza>();
            int count = Pizzas.Count;
            Pizza p = new Pizza();
            foreach(Pizza pizza in deletePizzas)
            {
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
                                WithdrawPizza?.Invoke($"Pizza {pM.pizzaName} deleted from order with price {pM.price}");
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
}