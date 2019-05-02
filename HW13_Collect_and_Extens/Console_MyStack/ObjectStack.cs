using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_MyStack
{
    public class ObjectStack
    {
        public const int maxSize = 10;
        public int size;
        public object[] array;

        public ObjectStack()
        {
            size = 0;
            array = new object[size];
        }

        public int Count()
        {
            int count = 0;
            foreach (object element in array)
            {
                count++;
            }
            return count;
        }

        public void Push(object ob)
        {
            if (size == maxSize)
                throw new Exception("There is maximum objects in stack");

            size++;
            object[] newArray = new object[array.Length + 1];
            Array.Copy(array, 0, newArray, 1, array.Length);
            array = newArray;
            array[0] = ob;
        }

        public object Pop()
        {
            if (size == 0)
                throw new Exception("There is no objects in stack");

            size--;
            object[] newArray = new object[array.Length - 1];
            Array.Copy(array, 1, newArray, 0, newArray.Length);
            object ob = array[0];
            array = newArray;
            return ob;
        }

        public object Peek()
        {
            if (size == 0)
                throw new Exception("There is no objects in stack");

            object ob = array[0];
            return ob;
        }
    }
}
