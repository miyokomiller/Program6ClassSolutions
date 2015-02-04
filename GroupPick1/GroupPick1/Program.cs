using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupPick1
{
    class Program
    {
        static void Main(string[] args)
        {
            //keeps Console open
            Console.ReadKey();
            //lists for student names and groups
            List<string> currentStudentList = new List<string>();

           currentStudentList.Add("Brandon E");
           currentStudentList.Add("Brandon S");
           currentStudentList.Add("Linda");
           currentStudentList.Add("Patrick");
           currentStudentList.Add("Daniel");
           currentStudentList.Add("Eugene");
           currentStudentList.Add("Mike G");
           currentStudentList.Add("Tim");
           currentStudentList.Add("Laura");
           currentStudentList.Add("Nicole");
           currentStudentList.Add("Maria");
           currentStudentList.Add("Nate");
           currentStudentList.Add("Andrii");
           currentStudentList.Add("Sergio");
           currentStudentList.Add("Mike S");
           currentStudentList.Add("Andrew");
           currentStudentList.Add("Juli");

           //sets group size to 4
           PickGroup(currentStudentList, 4);

           //keeps Console open
           Console.ReadKey();
        }
        /// <summary>
        /// randomly assign students to a group of 4
        /// </summary>
        /// <param name="currentStudentList">list of students</param>
        /// <param name="groupSize">size of groups</param>
       static void PickGroup (List<string> currentStudentList, int groupSize)     
    {
        //start count for groups
        int groupNumber = 1;

           //random number generate to pick random student names
        Random rnameg = new Random();
           //list that holds new group names
        List<string> currentGroupList = new List<string>();

        while (currentStudentList.Count > 0)
        {
            //picks random number to serve as an index
            int randomIndex = rnameg.Next(0, currentStudentList.Count);
            //uses the randomIndex to get a random student from the list
            string randomStudent = currentStudentList[randomIndex];
            //add the randomStudent to the currentGroupList
            currentGroupList.Add(randomStudent);
            //remove the randomStudent from the studentList
            currentStudentList.Remove(randomStudent);

                //check to see if the group is full or  if there are more students to assign
                if (currentGroupList.Count == groupSize || currentStudentList.Count == 0)
                {
                    //Writes group # to console
                    Console.WriteLine("Group {0}", groupNumber);

                   //console write group list
                    Console.WriteLine(string.Join("\n", currentGroupList));

                    Console.WriteLine();
                    //clear the currentGroupList for the next group
                    currentGroupList.Clear();
                    //increment the groupNumber for the next group
                    groupNumber++;
                }

        }
    }
            



        }

    }

