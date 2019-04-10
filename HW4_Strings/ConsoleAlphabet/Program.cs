using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAlphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            Alphabet alphabet = new Alphabet();
            //Console english alphabet
            alphabet.EngAlphabet();
            //Console reverse english alphabet
            alphabet.EngReverseAlphabet();
            //Console reverse english alphabet at line or column
            alphabet.EngReverseAlphabetList();

            Console.ReadKey();
        }
    }
}
