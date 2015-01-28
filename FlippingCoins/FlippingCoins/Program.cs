using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlippingCoins
{
    class Program
    {
        static Random randomNumberGen = new Random();

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(flipACoin());
            }
            Console.ReadKey();
        }
        /// <summary>
        /// flips a "coin"
        /// </summary>
        /// <returns>returns a string of either heads or tails</returns>
        static string flipACoin()
    {
        int theFlip = randomNumberGen.Next(0, 2);
            if (theFlip == 0)
            {
                return "Heads";
            }
            return "Tails";
    }
    
        static int FlipForHeads()
        {
            bool headsHasNotBeenFlipped = true;
            int howManyFlips = 0;
            while (headsHasNotBeenFlipped)
            {
                string theFlip = flipACoin();
                howManyFlips++;
                if (theFlip == "Heads")
                {
                    headsHasNotBeenFlipped = false;
                }
                Console.WriteLine(FlipForHeads());
            }
 return howManyFlips;
        }
    
    }
}
