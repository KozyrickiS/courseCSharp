using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Delivery
{
    public static class Notice
    {
        private const string FromMail = "MyUncleBob@yandex.ru";
        private const string FromMailPass = "UncleBob007";

        public static void SendEmail(Client client)
        {
            SendEmailForCompleteAsync(client).GetAwaiter();
            SendEmailForDeliverAsync(client).GetAwaiter();
            SendEmailForPaidAsync(client).GetAwaiter();
        }
        private static async Task SendEmailForCompleteAsync(Client client)
        {
            SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 587);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential(FromMail, FromMailPass);            
            MailMessage message = new MailMessage();
            message.From = new MailAddress(FromMail);
            message.To.Add(client.Email);            
            message.Subject = "Pizzeria UncleBob";
            message.Body += $"Dear {client.Name} {client.Midlname}. Your order is complete.\n" +
                $"You ordering ";
            foreach (Pizza pizza in client.ClientOrder.Pizzas)
            {
                message.Body += $"{pizza} ";
            }
            message.Body += "\n";
            message.Body += $"Price for your order is {client.ClientOrder.Price}\n";
            message.Body += "Thank you for choosing UncleBob";
            try
            {
                await smtp.SendMailAsync(message);
            }
            catch (SmtpException ex)
            {
                Console.WriteLine(ex.Message);
                Logger.Log.Error($"Client entered incorrect email");
                throw new Exception("Incorrect email");
            }
            Console.WriteLine("Message send");
        }

        private static async Task SendEmailForDeliverAsync(Client client)
        {
            SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 587);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential(FromMail, FromMailPass);
            MailMessage message = new MailMessage();
            message.From = new MailAddress(FromMail);
            message.To.Add(client.Email);
            message.Subject = "Pizzeria UncleBob";
            message.Body += $"Dear {client.Name} {client.Midlname}. Your order is delivered.\n" +
                $"You ordering ";
            foreach (Pizza pizza in client.ClientOrder.Pizzas)
            {
                message.Body += $"{pizza} ";
            }
            message.Body += "\n";
            message.Body += $"Please? pay {client.ClientOrder.Price} for your order\n";
            message.Body += "Thank you for choosing UncleBob";
            try
            {
                await smtp.SendMailAsync(message);
            }
            catch (SmtpException ex)
            {
                Console.WriteLine(ex.Message);
                Logger.Log.Error($"Client entered incorrect email");
                throw new Exception("Incorrect email");
            }
            Console.WriteLine("Message send");
        }

        private static async Task SendEmailForPaidAsync(Client client)
        {
            SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 587);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential(FromMail, FromMailPass);
            MailMessage message = new MailMessage();
            message.From = new MailAddress(FromMail);
            message.To.Add(client.Email);
            message.Subject = "Pizzeria UncleBob";
            message.Body += $"Dear {client.Name} {client.Midlname}. Your order is paid.\n";
            message.Body += "Thank you for choosing UncleBob";
            try
            {
                await smtp.SendMailAsync(message);
            }
            catch (SmtpException ex)
            {
                Console.WriteLine(ex.Message);
                Logger.Log.Error($"Client entered incorrect email");
                throw new Exception("Incorrect email");
            }
            Console.WriteLine("Message send");
        }
    }
}
