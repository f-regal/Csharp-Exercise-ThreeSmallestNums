using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciseThreeSmallestNums
{
    class MainClass
    {
        //Write a program and ask the user to supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10).
        //If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
        //otherwise, display the 3 smallest numbers in the list.


        public static void Main(string[] args)
        {
            List<int> listOfNums = new List<int>();
            List<int> threeSmallestNums = new List<int>();

            while (true)
            {
                Console.WriteLine("Please supply a list of 5 numbers which are seperated by commas");
                var userInput = Console.ReadLine();
                var listStrLineElements = userInput.Split(',').ToList();

                if (userInput == "" || listStrLineElements.Count < 5)
                {
                    Console.WriteLine("Invalid List, Please Re-try");
                    continue;
                }
                else
                {
                    foreach (var num in listStrLineElements)
                    {
                        listOfNums.Add(Int32.Parse(num));
                    }
                    break;
                }
            }

            listOfNums.Sort();

            for (var i = 0; i < 3; i++)
            {   
                threeSmallestNums.Add(listOfNums.Min());
                Console.WriteLine(listOfNums.Min());
                listOfNums.RemoveAt(0);
                
            }




        }
    }
}
