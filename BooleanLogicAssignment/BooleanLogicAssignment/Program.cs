using System;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //gathering age information from the user
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            //converting the information into an integer
            int appAge = Convert.ToInt32(age);
            //opperation to deturmine if the user is over the age of 15
            bool userAge = appAge > 15;

            //gathering DUI info from the user
            Console.WriteLine("Have you ever had a DUI? True or False?");
            //storing boolean data for later use
            bool trueOrFalse = Boolean.Parse(Console.ReadLine());

            //gatherin info on user's speeding tickers
            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            //converting information  into integer
            int numTickets = Convert.ToInt32(tickets);
            //storing boolean info for later use
            bool speedTkt = numTickets <= 3;

            //displayin to the user if they are qualified
            Console.WriteLine("Qualified?");
            //pulling the stored boolean information from previous questions and seeing if it meets qualifications
            bool qualification = userAge == true && trueOrFalse == false && speedTkt == true;
            //displaying the results
            Console.WriteLine(qualification);
            Console.ReadLine();

        }
    }
}
