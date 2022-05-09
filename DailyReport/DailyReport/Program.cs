using System;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Title displayed to user
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine();

            //resquest information from the user
            Console.WriteLine("What is your name?");
            //user types answer
            string myName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string myCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            int myPage = int.Parse(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
            bool myHelp = bool.Parse(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string myExperience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific");
            string myFeedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            int myHours = int.Parse(Console.ReadLine());
            //final message displays 
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

        }
    }
}
