using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            PutInArray();
        }
        private static void PutInArray()
        {
            Console.Write("Enter the length of array you want: ");
            int numbElements = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[numbElements];
            Console.WriteLine($"Enter first {numbElements - 1} elements of the array: ");
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write($"array[{i}]: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Now your array is: ");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Enter the number and position you want to put in this array");
            Console.Write("number: ");
            int newNumb = Convert.ToInt32(Console.ReadLine());
            Console.Write("position: ");
            int newNumbPosition = Convert.ToInt32(Console.ReadLine());
            if (newNumbPosition > array.Length - 1)
            {
                newNumbPosition = array.Length - 1;
                Console.WriteLine($"This position doesn't exist. Now position is [{newNumbPosition}]");
            }
            else if (newNumbPosition < 0)
            {
                newNumbPosition = 0;
                Console.WriteLine($"This position doesn't exist. Now position is [{newNumbPosition}]");
            }

            for (int i = array.Length - 1; i > newNumbPosition; i--)
            {
                array[i] = array[i - 1];
            }
            array[newNumbPosition] = newNumb;
            Console.Write("New array is: ");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.ReadKey();
        }
    }
}
