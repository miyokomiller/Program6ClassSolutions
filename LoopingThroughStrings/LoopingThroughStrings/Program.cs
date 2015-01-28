using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingThroughStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "the lazy dog jumps over the lazy girl";
            Console.WriteLine("we found {0} vowels in {1}", VowelCounter(testString), testString);
            VowelCounter(testString);
           
            Console.ReadKey();

        }
        /// <summary>
        /// ccount the number of vowles in a string
        /// </summary>
        /// <param name="inputText">the string to analyze</param>
        /// <returns>the number of vowels found</returns>
        static int VowelCounter(string inputText)
        {
            int numberOfVowelsFound = 0;
            for (int i = 0; i < inputText.Length; i = i + 1)
            {
                char letter = char.ToLower(inputText[i]);
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    numberOfVowelsFound = numberOfVowelsFound + 1;
                }
            }
            return numberOfVowelsFound;
        }
        /// <summary>
        /// Finds average word length
        /// </summary>
        /// <param name="inputText">string to analyze</param>
        /// <returns>average length of characters in a word</returns>
        static double AverageLengthofAWord(string inputText)
    {
        double totalNumberOfCharacters = 0;
        double totalNumberOFWords = 0;

        string[] wordArray = inputText.Split(" ");
            
            for (int i = 0; i < wordArray.Length; i++)
            {
                string currentWord = wordArray[i];

                totalNumberOFWords++;

                totalNumberOfCharacters ++ currentWord.Length;

            }
            return totalNumberOfCharacters / totalNumberOFWords;

       

            } 

}