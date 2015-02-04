using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1ReviewMM
{
    class Program
    {
        static void Main(string[] args)
        {
            SpaceRemover("a cat is a good pet");
            Console.ReadKey();
            // abuilt in space remover
            string noSpaces = "lots of spaces".Replace(" ", string.Empty);
            string vowelString = "aeiou";
        }
        

        /// <summary>
        /// Take in a string removes all the spaces
        /// </summary>
        static string SpaceRemover (string inputString)
        {
            //declare a empty return string
            string returnString = string.Empty;

            //loop over each letter
            for(int i = 0; i < inputString.Length; i++)
            {

                //get an individual letter
                string letter = inputString[i].ToString();
                if(letter != " ")
                {
                    //letter is not space
                    returnString = returnString + letter;

                }

            }
            return returnString;
            
        } 
        static void DeclaringVariables()
        {

        }
        
    }
   
}
