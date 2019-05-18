using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace Pizza_Delivery
{
    public class Client
    {
        public string Lastname { get; set; }
        public string Name { get; set; }
        public string Midlname { get; set; }
        public string HomeAddress { get; set; }
        public MailAddress Email { get; set; }
        public Order ClientOrder { get; set; }
        public Client()
        { }
        public Client(string lastname, string name, string midlname)
        {
            this.Lastname = lastname;
            this.Name = name;
            this.Midlname = midlname;
        }

        public Client ClientRegistration()
        {
            Client client = new Client();
            Console.WriteLine($"Welcome to the pizzeria {PizzaOrder.PizzeriaName}. Introduce youreself, please!");
            Console.WriteLine("Input your lastname:");
            client.Lastname = Console.ReadLine();
            Console.WriteLine("Input your name:");
            client.Name = Console.ReadLine();
            Console.WriteLine("Input your midname:");
            client.Midlname = Console.ReadLine();
            Console.WriteLine($"Hello, {client.Name} {client.Midlname}.");
            Logger.Log.Info($"Client lastname - {client.Lastname}, name - {client.Name}, midname - {client.Midlname} are created");
            Console.WriteLine("Please, tell the address where to deliver the order: ");
            client.HomeAddress = Console.ReadLine();
            Console.WriteLine("Please, tell Email where will be sent information about order status: ");
            string emailaddress = Console.ReadLine();
            client.Email = CheckEmail(client, emailaddress);
            return client;
        }

        private MailAddress CheckEmail(Client client, string emailaddress)
        {            
            try
            {
                client.Email = new MailAddress(emailaddress);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Logger.Log.Error($"Client {client.Lastname} {client.Name} entered incorrect email");
                throw new Exception("Incorrect email");
            }
            return client.Email;
        }
    }
}