using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //prompts user to enter a number
            Console.WriteLine("Please indicate a number: ");
            //tells the program to use the user's input
            string chNum = Console.ReadLine();
            //converts user's input into an integer
            int chosenNum = Convert.ToInt32(chNum);
            //calling Multiply method from Math.cs
            int MultiTotal = Math.Multiply(chosenNum);
            //displays results to the user
            Console.WriteLine( chosenNum + " times 5 = " + MultiTotal);
            //calling Add method from Math.cs
            int AddTotal = Math.Add(chosenNum);
            //displays results to the user
            Console.WriteLine(chosenNum + " plus 10 = "  + AddTotal);
            //calling Divide method from Math.cs
            int DivideTotal = Math.Divide(chosenNum);
            //displays results to the user
            Console.WriteLine(chosenNum + " divided by 2 = " + DivideTotal);
        }


    }


}
