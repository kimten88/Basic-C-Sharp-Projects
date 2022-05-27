using System;

namespace ParsingEnums
{
    class Program
    {
        //enum
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {


            try
            {
                //asking user to enter day
                Console.WriteLine("What day is it?");
                //assigning variable to user input
                string userAnswer = Console.ReadLine();
                //assigning the value to a variable of that enum data type 
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userAnswer);
                //displaying the enum data to the user
                Console.WriteLine(day + " is today!");

            }
            //if the user does not enter in information from the enum
            catch (Exception)
            {
                Console.WriteLine("Please enter an acutal day of the week");
            }
            Console.ReadLine();
        }
    }
}
