using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseArray();
        }
        private static void ReverseArray()
        {
            Console.Write("Enter the length of array you want: ");
            int numbElements = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[numbElements];
            int rev = 0;
            Console.WriteLine($"Enter {numbElements} elements of the array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"array[{i}]: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Your array is: ");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }

            for (int i = 0, j = array.Length - 1; i < array.Length / 2; i++, j--)
            {
                rev = array[i];
                array[i] = array[j];
                array[j] = rev;
            }
            Console.WriteLine();

            Console.Write("Your reverse array is: ");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.ReadKey();
        }
    }
}
