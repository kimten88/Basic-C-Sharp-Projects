using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please indicate a number: ");
            //tells the program to use the user's input
            string chNum = Console.ReadLine();
            //converts user's input into an integer
            int userValue = Convert.ToInt32(chNum);
            Console.WriteLine("Please select another number - optional: ");
            int userValue2;
            if (int.TryParse(Console.ReadLine(), out userValue2)) 
            {
                //calling Multiply method from Math.cs
                int MultiTotal = MathMethod.Multiply(userValue, userValue2);
                //displays results to the user
                Console.WriteLine(userValue + " * " + userValue2 + " * 5 = " + MultiTotal);
                //calling Add method from Math.cs
                int AddTotal = MathMethod.Add(userValue, userValue2);
                //displays results to the user
                Console.WriteLine(userValue + " + " + userValue2 + " + 10 = " + AddTotal);
                //calling Divide method from Math.cs
                int SubtrTotal = MathMethod.Subtract(userValue, userValue2);
                //displays results to the user
                Console.WriteLine(userValue + " - " + userValue2 + " - 2 = " + SubtrTotal);
            }
            else
            {
                //calling Multiply method from Math.cs
                int MultiTotal = MathMethod.Multiply(userValue);
                //displays results to the user
                Console.WriteLine(userValue + " * 5 = " + MultiTotal);
                //calling Add method from Math.cs
                int AddTotal = MathMethod.Add(userValue);
                //displays results to the user
                Console.WriteLine(userValue + " + 10 = " + AddTotal);
                //calling Divide method from Math.cs
                int SubtrTotal = MathMethod.Subtract(userValue);
                //displays results to the user
                Console.WriteLine(userValue + " - 2 = " + SubtrTotal);
            }






            
            
        }

    }
}
