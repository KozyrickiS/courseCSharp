using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your poem dividing lines with symbol ';' :");
            string poem = Console.ReadLine();
            string[] linePoem = poem.Split(';');
            for (int i = 0; i < linePoem.Length; i++)
            {
                linePoem[i] = linePoem[i].Replace("О", "А");
                linePoem[i] = linePoem[i].Replace("о", "а");
                Console.WriteLine(linePoem[i]);
            }

            Console.ReadKey();
        }
    }
}
