using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Class_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            //establishing variable for use
            int total;
            //asks user for a number
            Console.WriteLine("Please indicate a number: ");
            //tells the program to use the user's input as an integer
            int userValue = Convert.ToInt32(Console.ReadLine());
            //calling method with output 
            ClassClass.Divide(userValue, out total);
            //displaying to the user
            Console.WriteLine(userValue + " / 2  = " + total);
            Console.ReadLine();
            //asking for optional number to create opportunity for overload
            Console.WriteLine("Please select another number - optional: ");
            int userValue2;
            //telling the program which overload method to use
            if (int.TryParse(Console.ReadLine(), out userValue2))
            {
                //calling Multiply method from ClassClass
                int MultiTotal = ClassClass.Multiply(userValue, userValue2);
                //displays results to the user
                Console.WriteLine(userValue + " * " + userValue2 + " * 10 = " + MultiTotal);

            }
            else
            {
                //calling Multiply method from ClassClass.cs
                int MultiTotal = ClassClass.Multiply(userValue);
                //displays results to the user
                Console.WriteLine(userValue + " * 10 = " + MultiTotal);
            }

        }
    }
}
