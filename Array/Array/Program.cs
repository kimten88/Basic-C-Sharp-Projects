using System;
using System.Collections.Generic;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a string array
            string[] stringArray = { "Dog", "Fish", "Cat", "Bird", "Turtle" };
            //informing the user to enter the index number for the list
            Console.WriteLine("Please select an index number: ");
            int StringIndex = Convert.ToInt32(Console.ReadLine());
            //telling the program that the number the user enters needs to be less than or equal to the highest index value
            bool value = StringIndex <= 4;
            //path for the program to follow if the boolean is true
            if (value == true)
            {
                //displays the value of the index in the array
                Console.WriteLine(stringArray[StringIndex]);
                Console.ReadLine();
            }
            //path for the program to follow if the boolean is false
            else 
                    {
                Console.WriteLine("Index entered does not exsist");
            }
            //creating a numeric array
            int[] numArray = { 7, 19, 80, 197, 68, 55 };
            //asking user to enter an index number
            Console.WriteLine("Please select an index number: ");
            int numIndex = Convert.ToInt32(Console.ReadLine());
            bool value1 = numIndex <= 5;
            //program follows if true
            if (value1 == true)
            {
                //displays index value
                Console.WriteLine(numArray[numIndex]);
                Console.ReadLine();
            }
            //program follows if false
            else
            {
                //informs user that the number they entered is too high
                Console.WriteLine("Index entered does not exsist");
            }

            //creating a list of strings
            List<string> stringList = new List<string>();
            //adding values to the list
            stringList.Add("Sunflower");
            stringList.Add("Tulips");
            stringList.Add("Rose");
            stringList.Add("Daisy");
            stringList.Add("Lily");
            stringList.Add("Carnation");
            //asking user to enter index number
            Console.WriteLine("Please select an index number: ");
            int ListIndex = Convert.ToInt32(Console.ReadLine());
            bool value2 = ListIndex <= 5;
            //informing the program to follow these instructions of boolean value is true
            if (value2 == true)
            {
                Console.WriteLine(stringList[ListIndex]);
                Console.ReadLine();
            }
            else
            {
                //displays to the user if the boolean is not true/index number too high
                Console.WriteLine("Index entered does not exsist");
            }

        }
    }
}
