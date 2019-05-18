using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_MyStack
{
    public class TypeStack<T>
    {
        public const int maxSize = 10;
        public int size;
        public T[] array;

        public TypeStack()
        {
            size = 0;
            array = new T[size];
        }

        public int Count()
        {
            int count = 0;
            foreach (T element in array)
            {
                count++;
            }
            return count;
        }

        public void Push(T ob)
        {
            if (size == maxSize)
                throw new Exception("There is maximum objects in stack");

            size++;
            T[] newArray = new T[array.Length + 1];
            Array.Copy(array, 0, newArray, 1, array.Length);
            array = newArray;
            array[0] = ob;
        }

        public T Pop()
        {
            if (size == 0)
                throw new Exception("There is no objects in stack");

            size--;
            T[] newArray = new T[array.Length - 1];
            Array.Copy(array, 1, newArray, 0, newArray.Length);
            T ob = array[0];
            array = newArray;
            return ob;
        }

        public T Peek()
        {
            if (size == 0)
                throw new Exception("There is no objects in stack");

            T ob = array[0];
            return ob;
        }
    }
}
