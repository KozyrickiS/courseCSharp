using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMove
{
    class Player
    {
        private const char up = 'w';
        private const char down = 's';
        private const char left = 'a';
        private const char right = 'd';

        public void MovementPlayer(int countUp, int countDown, int countLeft, int countRight)
        {
            Console.WriteLine("Enter a symbol to move your character:");
            char symbol = Console.ReadKey().KeyChar;
            Console.WriteLine();
            switch (symbol)
            {
                case up:
                    {
                        Console.WriteLine("Сharacter moves up");
                        countUp++;
                    }
                    break;
                case down:
                    {
                        Console.WriteLine("Сharacter moves down");
                        countDown++;
                    }
                    break;
                case left:
                    {
                        Console.WriteLine("Сharacter moves to the left");
                        countLeft++;
                    }
                    break;
                case right:
                    {
                        Console.WriteLine("Сharacter moves to the right");
                        countRight++;
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
                MovementPlayer(countUp, countDown, countLeft, countRight);
            }
            else
            {
                Console.WriteLine($"Your character moves up {countUp} times, moves dowm {countDown} times, moves to the right {countRight} times and moves to the left {countLeft} times.");
            }
            Console.WriteLine("You made your choice. Bye-Bye");
        }
    }
}
