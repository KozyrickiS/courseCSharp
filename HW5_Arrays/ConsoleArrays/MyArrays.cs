using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArrays
{
    class MyArrays
    {
        public int _numbElements;
        public int[] handArray;
        public int[] randArray;
        public int[] RadnomArray(int numbElements)
        {
            _numbElements = numbElements;
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
            int[] randomArray = new int[numbElements];
            Random random = new Random();
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = random.Next(randMinValue, randMaxValue);
            }
            Console.Write("Your random array is: ");
            foreach (int element in randomArray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("");
            return randomArray;
        }
        public int[] ManualArray(int numbElements)
        {
            _numbElements = numbElements;
            int[] handArray = new int[numbElements];
            Console.WriteLine($"Enter {numbElements} elements of the array: ");
            for (int i = 0; i < handArray.Length; i++)
            {
                handArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Your manual array is: ");
            foreach (int element in handArray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("");
            return handArray;
        }
        public void SumOfArrays(int[] firstArray, int[] secondArray)
        {
            handArray = firstArray;
            randArray = secondArray;
            if (handArray.Length != randArray.Length)
            {
                Console.WriteLine("Wrong Arrays");
                return;
            }
            int[] sumArray = new int[handArray.Length];
            for (int i = 0; i < handArray.Length; i++)
            {
                sumArray[i] = handArray[i] + randArray[i];
            }
            Console.Write("Your summary array is: ");
            foreach (int element in sumArray)
            {
                Console.Write(element + " ");
            }
        }
        public void PutInArray(int numbElements)
        {
            _numbElements = numbElements;
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
        }
        public void ReverseArray(int numbElements)
        {
            _numbElements = numbElements;
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
        }
    }
}
