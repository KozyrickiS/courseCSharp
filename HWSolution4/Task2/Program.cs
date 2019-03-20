using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MovementPlayer(0, 0, 0, 0);
        }
        private static void MovementPlayer(int countW, int countS, int countA, int countD)
        {
            Console.WriteLine("Enter a symbol to move your character:");
            char symbol = Console.ReadKey().KeyChar;
            Console.WriteLine();
            switch (symbol)
            {
                case 'w':
                    {
                        Console.WriteLine("Сharacter moves up");
                        countW++;
                    }
                    break;
                case 's':
                    {
                        Console.WriteLine("Сharacter moves down");
                        countS++;
                    }
                    break;
                case 'a':
                    {
                        Console.WriteLine("Сharacter moves to the left");
                        countA++;
                    }
                    break;
                case 'd':
                    {
                        Console.WriteLine("Сharacter moves to the right");
                        countD++;
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Сharacter standing still");
                    }
                    break;
            }
            Console.WriteLine("Do you want to continue? y/n");
            char symbToCont = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if (symbToCont == 'y')
            {
                MovementPlayer(countW, countS, countA, countD);
            }
            else
            {
                Console.WriteLine($"Your character moves up {countW} times, moves dowm {countS} times, moves to the right {countD} times and moves to the left {countA} times.");
            }
            Console.WriteLine("You made your choice. Bye-Bye");
            Console.ReadKey();
        }
    }
}
