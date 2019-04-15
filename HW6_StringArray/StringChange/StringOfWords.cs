using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringChange
{
    public class StringOfWords
    {
        public string wordLine { get; set; }
        public StringOfWords()
        { }
        public StringOfWords(string wordLine)
        {
            this.wordLine = wordLine;
        }
        public void KillLongestWord()
        {
            string[] wordsArray = wordLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
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
                    wordLine = wordLine.Replace(wordsArray[i], String.Empty);

                }
            }
            wordLine = string.Join(" ", wordLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            Console.WriteLine(wordLine);
        }
        public void ReplaseLongAndShortWord()
        {
            string[] wordsArray = wordLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
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
            wordLine = String.Join(" ", wordsArray);
            Console.WriteLine(wordLine);
        }
        public void CalculationString()
        {
            char[] charArray = wordLine.ToCharArray();
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
        public void SortStringArray()
        {
            string[] wordsArray = wordLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

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
            wordLine = String.Join(" ", wordsArray);
            Console.WriteLine(wordLine);
        }
    }
}
