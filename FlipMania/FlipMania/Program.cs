using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipMania
{
    class Program
    { 
        static void Main(string[] args)
        {
            FlipsCoin(10000);
            FlipForHeads(10000);

            //keep console open
            Console.ReadKey();
        }
       //Flips Coin and Can input number of flips wanted
        static void FlipsCoin(int numberOFlips)
        {
            //to create a random number generator
            Random randomnumbergenerator = new Random();
            //what data we need to keep track of 
            int numberOfHeads = 0;
            int numberOfTails = 0;

            for (int i = 0; i < numberOFlips; i++)
            {
                //flips coin
                int coin= randomnumbergenerator.Next(0,2);
                //add to Head Count when random  generator shoots out a 0
                if (coin == 0)
                {
                    numberOfHeads++;
                    
                }
                //add to tail count when random generator shoots out a 1
                else 
                {
                    numberOfTails++;
                    
                }
                
            }
            //Oput AFTER the loops completes 
            Console.WriteLine("We flipped a coin " + numberOFlips + " times");
            Console.WriteLine("Number of Tails " + numberOfTails);
            Console.WriteLine("Number of Heads " + numberOfHeads);


        }
        static void FlipForHeads(int numberOfHeadsWanted)
        {
            //what data do we need?
            int numberOfHeadsFlipped = 0;
            int totalflips = 0;
            //create a random number generator 
            Random random= new Random();
            random.Next(2);
            //keeps track of number heads flipped until reach wanted amount
            while (numberOfHeadsWanted!=numberOfHeadsFlipped)
            {
                //if roles a Head if gets a zero
                if (random.Next(2) == 0)
                {
                    numberOfHeadsFlipped++;
                }
                
                    totalflips++;
               

            }
            Console.WriteLine("we are flipping the coin until we find " + numberOfHeadsWanted + " heads");
            
            Console.WriteLine("It took "+ totalflips+ " to find "+ numberOfHeadsWanted+" heads");
            //easier way to write code from above 
            //console.WriteLine("it took us {0} flips to get {1} heads", totalflips, numberOfHeadsWanted);
        }
    }
}

        
    

