using System;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.WriteLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrFalse = 12 < 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine();

            //int roomTemp = 70;
            //int currentTemp = 70;

            ////bool isWarm = currentTemp <= roomTemp;

            //bool isWarm = currentTemp != roomTemp;
            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            //Console.WriteLine("Please indicate a number: ");
            //string chNum = Console.ReadLine();
            //int chosenNum = Convert.ToInt32(chNum);
            //int total = chosenNum * 50;
            //Console.WriteLine("Your number times 50 is: " + total);
            //Console.ReadLine();


            //Console.WriteLine("Please indicate a number: ");
            //string chNum = Console.ReadLine();
            //int chosenNum = Convert.ToInt32(chNum);
            //int total = chosenNum + 25;
            //Console.WriteLine("Your number plus 25 is: " + total);
            //Console.ReadLine();


            //Console.WriteLine("Please indicate a number: ");
            //string chNum = Console.ReadLine();
            //int chosenNum = Convert.ToInt32(chNum);
            //int total = (int)(chosenNum / 12.5);
            //Console.WriteLine("Your number divided by 12.5 is: " + total);
            //Console.ReadLine();


            //Console.WriteLine("Please indicate a number: ");
            //string chNum = Console.ReadLine();
            //int chosenNum = Convert.ToInt32(chNum);
            //bool trueorfalse = chosenNum > 50;
            //Console.WriteLine(trueorfalse.ToString());
            //Console.ReadLine();

            Console.WriteLine("Please indicate a number: ");
            string chNum = Console.ReadLine();
            int chosenNum = Convert.ToInt32(chNum);
            int remainder = chosenNum % 2;
            Console.WriteLine(remainder);
            Console.ReadLine();
        }
    }
}
