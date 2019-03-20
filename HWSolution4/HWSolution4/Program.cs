using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWSolution4
{
    class Program
    {
        static void Main(string[] args)
        {
            //EngAlphabet();222
            EngAlphabetList();
        }

        private static void EngAlphabet()
        {
            Console.WriteLine("English reverse order Alphabet from unicode: ");
            for (int i = 90; i > 64; i--)
            {
                Console.WriteLine((char)i);
            }
            Console.WriteLine("that's all folks!");
            Console.ReadKey();
        }

        private static void EngAlphabetList()
        {
            List<char> alphabet = new List<char>();
            for (int i = 90; i > 64; i--)
            {
                alphabet.Add((char)i);
            }
            Console.WriteLine("How to display a reverse order Alphabet?");
            Console.WriteLine("1.line or 2.column: ");
            int or = Convert.ToInt32(Console.ReadLine());
            switch (or)
            {
                case 1:
                    Console.WriteLine("Reverse order Alphabet in line:");
                    foreach (char val in alphabet)
                    {
                        Console.Write(val);
                    }
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine("Reverse order Alphabet in column:");
                    foreach (char val in alphabet)
                    {
                        Console.WriteLine(val);
                    }
                    break;
                default:
                    Console.WriteLine("NO!!! Something was broken. Try again");
                    break;
            }
            if (or != 1 && or != 2)
            {
                EngAlphabetList();
            }
            Console.WriteLine("that's all folks!");
            Console.ReadKey();
        }
    }
}
