using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();
            //Task1
            numbers.SumOfNumbers();
            //or
            numbers.SumOfNumbers(3, 4);
            //Task2
            numbers.CheckSumOfNumbers();
            //or
            numbers.CheckSumOfNumbers(3, 4, 8);
            //Task3
            numbers.CheckSumWithAddition();
            //or
            numbers.CheckSumWithAddition(3, 4, 8);
            //Task4
            numbers.CheckCalc();
            //or
            numbers.CheckCalc(3, 4, "+", 7);

            Console.ReadKey();
        }
    }
}
