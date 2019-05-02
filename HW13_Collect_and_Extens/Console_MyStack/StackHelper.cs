using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_MyStack
{
    public static class StackHelper
    {
        public static void GetCapacity(this ObjectStack stack)
        {
            int capacity = stack.Count();
            Console.WriteLine($"your free capacity is: {ObjectStack.maxSize - capacity}");
        }
        public static void GetCapacity<T>(this TypeStack<T> typeStack)
        {
            int capacity = typeStack.Count();
            Console.WriteLine($"your free capacity is: {ObjectStack.maxSize - capacity}");
        }
    }
}
