using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreeArray();
        }
        private static void ThreeArray()
        {
            Console.Write("What length of array you want? ");
            int numbElements = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What min value and max value you want in your random array?");
            Console.Write("min value: ");
            int randMinValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("max value: ");
            int randMaxValue = Convert.ToInt32(Console.ReadLine());
            if (randMinValue > randMaxValue)
            {
                int rand = randMaxValue;
                randMaxValue = randMinValue;
                randMinValue = rand;
                Console.WriteLine($"You are not very smart guy. We fix your problem. Now min value = {randMinValue}, and max value = {randMaxValue}.");
            }

            int[] handArray = new int[numbElements];
            int[] randomArray = new int[numbElements];
            int[] sumArray = new int[numbElements];
            Console.WriteLine($"Enter {numbElements} elements of the first array: ");
            for (int i = 0; i < handArray.Length; i++)
            {
                handArray[i] = Convert.ToInt32(Console.ReadLine());
                randomArray[i] = new Random().Next(randMinValue, randMaxValue);
                sumArray[i] = handArray[i] + randomArray[i];
            }

            Console.Write("Your manual array is: ");
            foreach (int element in handArray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.Write("Your random array is: ");
            foreach (int element in randomArray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.Write("Your summary array is: ");
            foreach (int element in sumArray)
            {
                Console.Write(element + " ");
            }
            Console.ReadKey();
        }
    }
}
