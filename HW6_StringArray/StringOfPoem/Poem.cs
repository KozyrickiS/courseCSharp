using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOfPoem
{
    class Poem
    {
        public string poem { get; set; }
        public Poem(string poem)
        {
            this.poem = poem;
        }
        public Poem()
        {
        }
        public void SplitByChar()
        {
            string[] linePoem = poem.Split(';');
            for (int i = 0; i < linePoem.Length; i++)
            {
                linePoem[i] = linePoem[i].Replace("О", "А");
                linePoem[i] = linePoem[i].Replace("о", "а");
                Console.WriteLine(linePoem[i]);
            }
        }
        public void SplitByChar(char splitSymbol)
        {
            string[] linePoem = poem.Split(splitSymbol);
            for (int i = 0; i < linePoem.Length; i++)
            {
                linePoem[i] = linePoem[i].Replace("О", "А");
                linePoem[i] = linePoem[i].Replace("о", "а");
                Console.WriteLine(linePoem[i]);
            }
        }
    }
}
