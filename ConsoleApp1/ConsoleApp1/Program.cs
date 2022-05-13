using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////creating a string array
            //string[] stringArray = { "Dog", "Fish", "Cat", "Bird", "Turtle" };
            ////informing the user to enter the index number for the list
            //Console.WriteLine("Please give a last name for the animals: ");
            //string userInput = Console.ReadLine();

            ////iteration instructions, was changed to i-- for in infinite loop and corrected to i++
            //for (int i = 0; i < stringArray.Length; i++)
            //{
            //    //displays the value of the index in the array
            //    Console.WriteLine(stringArray[i] + " " + userInput);

            //}
            //Console.ReadLine();

            //List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
            //List<int> passingScores = new List<int>();

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        passingScores.Add(score);
            //    }
            //}
            //Console.WriteLine(passingScores.Count);
            //Console.ReadLine();

            //int[] numArray = { 7, 19, 80, 197, 68, 55 };


            //foreach (int number in numArray)
            //{
            //    if (number <= 50)
            //        //displays index value
            //        Console.WriteLine(number);

            //}
            //Console.ReadLine();


            //int[] numArray2 = { 28, 35, 110, 67, 7, 150 };


            //foreach (int number2 in numArray2)
            //{
            //    if (number2 < 100)
            //        //displays index value
            //        Console.WriteLine(number2);
            //}
            //Console.ReadLine();


            //List<string> carTypes = new List<string>() { "sedan", "coupe", "truck", "SUV", "van" };
            //Console.WriteLine("Please select a type of vehicle: ");
            //string userType = Console.ReadLine();

            //foreach (string car in carTypes)
            //{
            //    if (car == userType)
            //    {
            //        Console.WriteLine("This type is in the list " + userType);
            //        break;
            //    }

            //    else
            //    {
            //        Console.WriteLine("This type is not in the list");
            //    }
            //}

            //List<string> weekDays = new List<string>() { "Friday", "Tuesday", "Friday", "Thursday", "Wednesday" };
            //Console.WriteLine("Please enter which day of the week you would like an appointment : ");
            //string userSearch = Console.ReadLine();

            //for (int w = 0; w < weekDays.Count; w++)
            //{
            //    if (weekDays[w] == userSearch)
            //    {
            //        Console.WriteLine("Your appointment is confirmed for " + userSearch);
            //        break;
            //    }

            //    else
            //    {
            //        Console.WriteLine("This day is not available");

            //    }

            //}

            List<string> fruits = new List<string>() { "Apple", "Pear", "Orange", "Apple", "Orange", "Peach" };


            var myList = new List<string>();
            var duplicates = new List<string>();

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
