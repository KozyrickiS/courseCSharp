using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAlphabet
{
    class Alphabet
    {
        private const int AUnicodeNumb = 65;
        private const int ZUnicodeNumb = 90;

        public void EngAlphabet()
        {
            Console.WriteLine("English Alphabet from unicode: ");
            for (int i = AUnicodeNumb; i <= ZUnicodeNumb; i++)
            {
                Console.WriteLine((char)i);
            }
            Console.WriteLine("that's all folks!");
        }
        public void EngReverseAlphabet()
        {
            Console.WriteLine("English reverse order Alphabet from unicode: ");
            for (int i = ZUnicodeNumb; i >= AUnicodeNumb; i--)
            {
                Console.WriteLine((char)i);
            }
            Console.WriteLine("that's all folks!");
        }
        public void EngReverseAlphabetList()
        {
            List<char> alphabet = new List<char>();
            for (int i = ZUnicodeNumb; i >= AUnicodeNumb; i--)
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
                EngReverseAlphabetList();
            }
            Console.WriteLine("that's all folks!");
        }
    }
}
