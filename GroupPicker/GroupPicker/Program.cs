using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupPicker
{
    class Program
    {
        static void Main(string[] args)
        {
        }
      static List<string> firstNames = new List<string>();
    firstNames.Add("name1");
    firstNames.Add("name2");
    firstNames.Add("name3");
    firstNames.Add("namen");

    static Random randNum = new Random();
    static int aRandomPos = randNum.Next(firstNames.Count);//Returns a nonnegative random number less than the specified maximum (firstNames.Count).

   static string currName = firstNames[aRandomPos];
        

    }
}
