using System;

namespace mathAndComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            //gather information for person 1
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate: ");
            string p1Rate = Console.ReadLine();
            int rateP1 = Convert.ToInt32(p1Rate);
            Console.WriteLine("Hours worked this week: ");
            string p1Week = Console.ReadLine();
            int WkP1 = Convert.ToInt32(p1Week);
            int p1salary = rateP1 * WkP1 * 52;
            Console.WriteLine("Annual Salary of Person 1: " + p1salary);

            //gather info for person 2
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate: ");
            string p2Rate = Console.ReadLine();
            int rateP2 = Convert.ToInt32(p2Rate);
            Console.WriteLine("Hours worked this week: ");
            string p2Week = Console.ReadLine();
            int WkP2 = Convert.ToInt32(p2Week);
            int p2salary = rateP2 * WkP2 * 52;
            Console.WriteLine("Annual Salary of Person 2: " + p2salary);

            //boolean to compare person 1 & 2's saleries
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool trueOrFalse = p1salary > p2salary;
            Console.WriteLine(trueOrFalse);
            Console.ReadLine();

        }
    }
}
