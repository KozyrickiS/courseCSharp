using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOfPoem
{
    class Program
    {
        static void Main(string[] args)
        {
            Poem poem = new Poem("one two three four five bunny walking with the knife");
            poem.SplitByChar(' ');
            Poem poem2 = new Poem();
            poem2.poem = Console.ReadLine();
            poem2.SplitByChar();
            Console.ReadKey();
        }
    }
}
