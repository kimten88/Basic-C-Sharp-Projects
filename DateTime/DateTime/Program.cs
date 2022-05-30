using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //have the program display the current time
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            //asking user for the number of hours
            Console.WriteLine("Please enter a number of hours to see the future time");
            //converting the string input into a doulbe for use in DateTime
            double userTime = Convert.ToDouble(Console.ReadLine());
            //adding those hours the user provided and adding them to the current time
            DateTime enteredTime = now.AddHours(userTime);
            //displaying for the user to see
            Console.WriteLine("It will be: " + enteredTime);
            Console.ReadLine();

            
        }
    }
}
