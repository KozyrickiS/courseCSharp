using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_MyStack
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectStack stack = new ObjectStack();
            stack.Push(5);
            stack.Push("time to sleep");
            Console.WriteLine(stack.Count());
            stack.Push(DateTime.Now);
            stack.Push(21);
            var first = stack.Pop();
            Console.WriteLine(first);
            var second = stack.Peek();
            Console.WriteLine(second);

            Console.ReadLine();
        }
    }
}
