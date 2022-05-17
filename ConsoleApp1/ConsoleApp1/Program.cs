using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a string array
            string[] stringArray = { "Dog", "Fish", "Cat", "Bird", "Turtle" };
            //asking for user input
            Console.WriteLine("Please give a last name for the animals: ");
            string userInput = Console.ReadLine();

            //iteration instructions
            for (int i = 0; i < stringArray.Length; i++)
            {
                //concatenated the array with the user input 
                stringArray[i] = stringArray[i] + " " + userInput;

            }
            //interating to display modified array
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }
            Console.ReadLine();

            //creating a string array for Part 2
            string[] Part2 = { "Cup", "Glass", "Mug" };

            //iteration instructions, was changed to p-- for in infinite loop and corrected to p++
            for (int i = 0; i < Part2.Length; i++)
            {
                //displays the value of the index in the array
                Console.WriteLine(Part2[i]);
            }
            Console.ReadLine();

            //integer list
            List<int> testScores = new List<int> { 98, 99, 12, 74, 23, 99 };
            //comparison use to determine whether to continue iterating '<' operator
            for (int i = 0; i < testScores.Count; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();


            int[] numArray = { 7, 19, 80, 197, 68, 55 };
            //comparison use to determine whether to continue iterating '<=' operator
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(numArray[i]);
            }
            Console.ReadLine();


            //new integer array
            int[] numArray2 = { 28, 35, 110, 67, 7, 150 };

            foreach (int number2 in numArray2)
            {
                if (number2 < 100)
                    //displays index value
                    Console.WriteLine(number2);
            }
            Console.ReadLine();


            //string list with user input
            List<string> carTypes = new List<string>() { "sedan", "coupe", "truck", "SUV", "van" };
            Console.WriteLine("Please select a type of vehicle: ");
            string userType = Console.ReadLine();
            bool found = false;

            for (int i = 0; i < carTypes.Count; i++)
            {
                if (carTypes[i] == userType)
                {
                    Console.WriteLine("This type is located at index: " + i);
                    found = true;
                    break;
                }
                //message displayed if user input is not in list

            }
            if (!found)
            {
                Console.WriteLine("This type is not in the list");
            }


            //user searched with duplicate strings
            List<string> weekDays = new List<string>() { "Friday", "Tuesday", "Friday", "Thursday", "Wednesday" };
            Console.WriteLine("Please enter which day of the week you would like an appointment : ");
            string userSearch = Console.ReadLine();
            //iterate through list
            for (int i = 0; i < weekDays.Count; i++)
            {
                //if the user search matches anything in the string
                if (weekDays[i] == userSearch)
                {
                    Console.WriteLine("This day exisits in index: " + i);
                }
                //if user search does not match list
                else
                {
                    Console.WriteLine("This day is not available");

                }

            }
            Console.ReadLine();


            //list with duplicate string
            List<string> fruits = new List<string>() { "Apple", "Pear", "Orange", "Apple", "Orange", "Peach" };

            var myList = new List<string>();
            var duplicates = new List<string>();
            //creating new lists which will only allow one value
            foreach (var f in fruits)
            {
                if (!myList.Contains(f))
                    myList.Add(f);
                else
                    duplicates.Add(f);
            }
            // show duplicates list
            foreach (var f in duplicates)
                Console.WriteLine(f + " has already appeared in this string");








        }
    }

}
