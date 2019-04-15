using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringChange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the line of words and split this words with 'space': ");
            //like that 
            //StringOfWords words = new StringOfWords();
            //words.wordLine = Console.ReadLine();
            //or
            StringOfWords words = new StringOfWords("one two three four five bunny walking with the knife");

            Console.WriteLine("You may choose what to do whith your array of words:");
            Console.WriteLine("1.	Remove the longest word");
            Console.WriteLine("2.	Swap the longest word with the shortest word");
            Console.WriteLine("3.	Count english and russian letters, spaces and other signs");
            Console.WriteLine("4.	Sort array of words descending");
            Console.WriteLine("Press the number from 1 to 4: ");
            if (int.TryParse(Console.ReadLine(), out int chosenMethod))
            {
                switch (chosenMethod)
                {
                    case 1:
                        {
                            words.KillLongestWord();
                            break;
                        }
                    case 2:
                        {
                            words.ReplaseLongAndShortWord();
                            break;
                        }
                    case 3:
                        {
                            words.CalculationString();
                            break;
                        }
                    case 4:
                        {
                            words.SortStringArray();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("This is not a number from 1 to 4!");
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("This is not a number!");
            }
            Console.ReadKey();
        }
    }
}
