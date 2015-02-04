using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //for loops too call FizzBuzz Function
            for (int i = 0; i <= 20; i++)
            {
                //write results of FizzBuzz function to the Console
                Console.WriteLine(FizzBuzz(i));
            }
            for (int j = 92; j <= 79; j--)
            {
                Console.WriteLine(FizzBuzz(j));
            }
            //Call DashInsert with parameters
            DashInsert(8675309);
            //call yodaizer function 
            Yodaizer("I like code");

            //callTextStats
            TextStats("CoDINg Is Fun!!!!@");
            
          
        }
        /// <summary>
        /// check if numbers in loop are diviable by 5 &/or 3
        /// </summary>
        /// <param name="number">number to be divided</param>
        /// <returns>fizz Buzz or fizzbuzz </returns>
        public static string FizzBuzz(int number)
        {


            //checks if divisable by both 5 & 3
            if (number % 3 == 0 && number % 5 == 0)
            {//reutns FizzBuzz
                return "FizzBuzz";
            }
            //checks if is divisable by 3
            if (number % 3 == 0)
            {
                //returns buzz
                return "Buzz";
            }//checks if divisable by 5
            else if (number % 5 == 0)
            {//returns fizz
                return "Fizz";
            }
            //returns number to string
            return number.ToString();

        }
        /// <summary>
        /// takes string of text ans reverses the order
        /// </summary>
        /// <param name="text">text to be reversed</param>
        /// <returns>reutrns text in reverse order</returns>
        public static string Yodaizer(string text)
        {
            //use .Split to seperate words in the string
            string[] revArray = text.Split(' ');

            // use a for loop to print the words in reverse order
            for (var i = revArray.Length - 1; i >= 0; i--)
            {
                return revArray[i] + ' ';
                
            }
            return string.Empty
        }
        /// <summary>
        /// function to loop through string of numbers and tell if Prime or not
        /// </summary>
        /// <param name="number">number to be found prime or not</param>
        /// <returns>True or if false returns the number</returns>
      
        public static bool IsPrime(int number)
        {
            bool IsPrime = true;
            //for loop that will cycle trough all numbers Between 1 and number passed through parameter
            for (var k = 2; k < number; k++)
            {
                //see if number is divisiable by any nummber between
                if (number % k == 0)
                {
                    //if conditon is met prime returns false and break loop'
                    IsPrime = false;
                    break;
                }
            }
            if (IsPrime == false)
            {
                return false;
            }
            else
            {
                Console.WriteLine(number + "is a prime number");
            }
            return true;
        }
        public static string DashInsert(int number)
        {
            //convert and store number as a string
            var numberString = number.ToString();

            //print first number 
            Console.WriteLine(numberString[0]);

            for (int f = 1; f < numberString.Length; f++)
            {
                if (Convert.ToInt32(numberString[f]) % 2 != 0)
                {
                    if (Convert.ToInt32(numberString[f - 1]) % 2 != 0)
                    {
                        Console.WriteLine("-" + numberString[f]);
                    }
                    else
                    {
                        Console.WriteLine(numberString[f]);
                    }
                }
                else
                {
                    Console.WriteLine(numberString[f]);
                }
            }

                return string.Empty;
        }
        public static void TextStats(string input)
        {
            //Initialize variables to 0
            int consonants = 0, vowels = 0, special = 0, words = 0;
            //Total characters = length of input
            int characters = input.Length;

            //Go through each character and check if it's a letter or a number
            foreach (char c in input)
            {
                //If it's not a letter or number, increase special char count by 1
                if (!char.IsLetterOrDigit(c.ToString(), 0))
                {
                    special++;
                }

                //Check for vowels, increase by 1 for each found
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                    c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                {
                    vowels++;
                }
                //Each space means that there has been 1 word
                if (c == ' ')
                {
                    words++;
                }
            }

            //Increase words by 1 because there's no initial space for that word
            words = words + 1;
            //Consonants = anything that's not a vowel or special char
            consonants = characters - special - vowels;

            Console.WriteLine("Characters: " + characters + "\n Consonants: " + consonants + "\n Special: " + special + "\n Vowels: "
                + vowels + "\n Words: " + words);
        }
    }

}