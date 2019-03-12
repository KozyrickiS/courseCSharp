using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1
            SumOfNumbers();
            //Task2
            CheckSumOfNumbers();
            //Task3
            CheckSumWithAddition();
            //Task4
            CheckCalc();
        }

        private static void SumOfNumbers()
        {
            Console.WriteLine("Enter first number: ");
            int firstNumb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondNumb = Convert.ToInt32(Console.ReadLine());
            int sum = firstNumb + secondNumb;
            Console.WriteLine("Sum of entered numbers = " + sum);
            Console.ReadKey();
        }

        private static void CheckSumOfNumbers()
        {
            Console.WriteLine("Enter first number:");
            int firstNumb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int secondNumb = Convert.ToInt32(Console.ReadLine());
            int sum = firstNumb + secondNumb;
            Console.WriteLine("Enter expected result:");
            int sumToCheck = Convert.ToInt32(Console.ReadLine());
            if (sum == sumToCheck)
            {
                Console.WriteLine("Right");
            }
            else
            {
                Console.WriteLine("Wrong");
            }
            Console.ReadKey();
        }
        private static void CheckSumWithAddition()
        {
            Console.WriteLine("Enter first number: ");
            int firstNumb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondNumb = Convert.ToInt32(Console.ReadLine());
            int sum = firstNumb + secondNumb;
            Console.WriteLine("Enter expected result:");
            int sumToCheck = Convert.ToInt32(Console.ReadLine());
            if (sum == sumToCheck)
            {
                Console.WriteLine("Right");
            }
            else if (sum > sumToCheck)
            {
                Console.WriteLine("Wrong");
                Console.WriteLine("Result must be more");
            }
            else if (sum < sumToCheck)
            {
                Console.WriteLine("Wrong");
                Console.WriteLine("Result must be less");
            }
            Console.ReadKey();
        }
        private static void CheckCalc()
        {
            Console.WriteLine("Enter first number: ");
            int firstNumb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondNumb = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            Console.WriteLine("Enter calc operator (+ or -):");
            string oper = Convert.ToString(Console.ReadLine());
            if (oper == "+")
            {
                result = firstNumb + secondNumb;
            }
            else if (oper == "-")
            {
                result = firstNumb - secondNumb;
            }
            Console.WriteLine("Enter expected result:");
            int resultToCheck = Convert.ToInt32(Console.ReadLine());
            if (result == resultToCheck)
            {
                Console.WriteLine("Right");
            }
            else if (result > resultToCheck)
            {
                Console.WriteLine("Wrong");
                Console.WriteLine("Result must be more");
            }
            else if (result < resultToCheck)
            {
                Console.WriteLine("Wrong");
                Console.WriteLine("Result must be less");
            }
            Console.ReadKey();
        }
    }
}
