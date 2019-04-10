using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumbers
{
    class Numbers
    {
        private int firstNumb;
        private int secondNumb;
        private int result;
        private int resultToCheck;
        private string checkAnswer;
        private string operand;

        private void SumTwoNumb()
        {
            Console.WriteLine("Enter first number: ");
            firstNumb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            secondNumb = Convert.ToInt32(Console.ReadLine());
            result = firstNumb + secondNumb;
        }
        public void SumOfNumbers()
        {
            SumTwoNumb();
            Console.WriteLine("Sum of entered numbers = " + result);
        }
        public void SumOfNumbers(int firstNumb, int secondNumb)
        {
            this.firstNumb = firstNumb;
            this.secondNumb = secondNumb;
            result = firstNumb + secondNumb;
            Console.WriteLine("Sum of entered numbers = " + result);
        }
        public void CheckSumOfNumbers()
        {
            SumTwoNumb();
            Console.WriteLine("Enter expected result:");
            resultToCheck = Convert.ToInt32(Console.ReadLine());
            if (result == resultToCheck)
            {
                checkAnswer = "Right";
            }
            else
            {
                checkAnswer = "Wrong";
            }
            Console.WriteLine(checkAnswer);
        }
        public void CheckSumOfNumbers(int firstNumb, int secondNumb, int resultToCheck)
        {
            this.firstNumb = firstNumb;
            this.secondNumb = secondNumb;
            this.resultToCheck = resultToCheck;
            result = firstNumb + secondNumb;
            if (result == resultToCheck)
            {
                checkAnswer = "Right";
            }
            else
            {
                checkAnswer = "Wrong";
            }
            Console.WriteLine(checkAnswer);
        }
        public void CheckSumWithAddition()
        {
            CheckSumOfNumbers();
            if (result > resultToCheck)
            {
                Console.WriteLine("Result must be more");
            }
            else if (result < resultToCheck)
            {
                Console.WriteLine("Result must be less");
            }
        }
        public void CheckSumWithAddition(int firstNumb, int secondNumb, int resultToCheck)
        {
            CheckSumOfNumbers(firstNumb, secondNumb, resultToCheck);
            if (result > resultToCheck)
            {
                Console.WriteLine("Result must be more");
            }
            else if (result < resultToCheck)
            {
                Console.WriteLine("Result must be less");
            }
        }
        public void CheckCalc()
        {
            Console.WriteLine("Enter first number: ");
            firstNumb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            secondNumb = Convert.ToInt32(Console.ReadLine());
            result = 0;
            Console.WriteLine("Enter calc operator (+ or -):");
            string oper = Convert.ToString(Console.ReadLine());
            if (oper.Equals("+"))
            {
                result = firstNumb + secondNumb;
            }
            else if (oper.Equals("-"))
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
        }
        public void CheckCalc(int firstNumb, int secondNumb, string operand, int resultToCheck)
        {
            this.firstNumb = firstNumb;
            this.secondNumb = secondNumb;
            this.operand = operand;
            this.resultToCheck = resultToCheck;
            result = 0;
            if (operand.Equals("+"))
            {
                result = firstNumb + secondNumb;
            }
            else if (operand.Equals("-"))
            {
                result = firstNumb - secondNumb;
            }
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
        }
    }
}
