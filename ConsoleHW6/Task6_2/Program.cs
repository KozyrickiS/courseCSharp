using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the line of words and split this words with 'space': ");
            string wordLine = Console.ReadLine();
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
                            KillLongestWord(wordLine);
                            break;
                        }
                    case 2:
                        {
                            ReplaseLongAndShortWord(wordLine);
                            break;
                        }
                    case 3:
                        {
                            CalculationString(wordLine);
                            break;
                        }
                    case 4:
                        {
                            SortStringArray(wordLine);
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
        private static void KillLongestWord(string stringOfWords)
        {
            string[] wordsArray = stringOfWords.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string longestWord = wordsArray[0];
            int longestLength = 0;
            string[] newWordArray = new string[wordsArray.Length - 1];
            for (int i = 0; i < wordsArray.Length; i++)
            {
                if (longestWord.Length < wordsArray[i].Length)
                {
                    longestWord = wordsArray[i];
                    longestLength = wordsArray[i].Length;
                }
            }

            for (int i = 0; i < wordsArray.Length; i++)
            {
                if (wordsArray[i].Length == longestLength)
                {
                    stringOfWords = stringOfWords.Replace(wordsArray[i], String.Empty);

                }
            }
            stringOfWords = string.Join(" ", stringOfWords.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            Console.WriteLine(stringOfWords);
        }
        private static void ReplaseLongAndShortWord(string stringOfWords)
        {
            string[] wordsArray = stringOfWords.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int longestLength = wordsArray[0].Length;
            int shortestLength = wordsArray[0].Length;
            for (int i = 0; i < wordsArray.Length; i++)
            {
                if (longestLength < wordsArray[i].Length)
                {
                    longestLength = wordsArray[i].Length;
                }
                if (shortestLength > wordsArray[i].Length)
                {
                    shortestLength = wordsArray[i].Length;
                }
            }
            if (longestLength != shortestLength)
            {
                string SwapWord = null;
                int longSwapID = -1;
                int shortSwapID = -1;
                for (int i = 0; i < wordsArray.Length; i++)
                {
                    if (wordsArray[i].Length == longestLength)
                    {
                        longSwapID = i;
                    }
                    else if (wordsArray[i].Length == shortestLength)
                    {
                        shortSwapID = i;
                    }
                    if ((longSwapID != -1) && (shortSwapID != -1))
                    {
                        SwapWord = wordsArray[longSwapID];
                        wordsArray[longSwapID] = wordsArray[shortSwapID];
                        wordsArray[shortSwapID] = SwapWord;
                        longSwapID = -1;
                        shortSwapID = -1;
                    }
                }
            }

            stringOfWords = String.Join(" ", wordsArray);
            Console.WriteLine(stringOfWords);
        }
        private static void CalculationString(string stringOfWords)
        {
            char[] charArray = stringOfWords.ToCharArray();
            int countSmallENGLetters = 0;
            int countBigENGLetters = 0;
            int countSmallRUSLetters = 0;
            int countBigRUSLetters = 0;
            int countOfSpaces = 0;
            int countOfSign = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if ((charArray[i] > (char)64) && (charArray[i]) < (91))
                {
                    countBigENGLetters++;
                }
                else if ((charArray[i] > (char)96) && (charArray[i]) < (123))
                {
                    countSmallENGLetters++;
                }
                else if ((charArray[i] > (char)1039) && (charArray[i]) < (1072))
                {
                    countBigRUSLetters++;
                }
                else if ((charArray[i] > (char)1071) && (charArray[i]) < (1104))
                {
                    countSmallRUSLetters++;
                }
                else if (charArray[i] == (char)32)
                {
                    countOfSpaces++;
                }
                else
                {
                    countOfSign++;
                }
            }
            Console.WriteLine("In our StringLine we have: big english letters = " + countBigENGLetters + ", small english letters = " + countSmallENGLetters + ", big russian letters = " + countBigRUSLetters + ", small russian letters = " + countSmallRUSLetters + ", spaces = " + countOfSpaces + " and other signs = " + countOfSign);
        }
        private static void SortStringArray(string stringOfWords)
        {
            string[] wordsArray = stringOfWords.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < wordsArray.Length; i++)
            {
                for (int j = 0; j < wordsArray.Length - i - 1; j++)
                {
                    if (wordsArray[j].Length < wordsArray[j + 1].Length)
                    {
                        string temp = wordsArray[j];
                        wordsArray[j] = wordsArray[j + 1];
                        wordsArray[j + 1] = temp;
                    }
                }
            }

            stringOfWords = String.Join(" ", wordsArray);
            Console.WriteLine(stringOfWords);
        }
    }
}
