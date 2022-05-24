using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //create object
            MathMethod m = new MathMethod();
            //as user for first number
            Console.WriteLine("Pick a number:");
            //set variable for first number
            int data = Convert.ToInt32(Console.ReadLine());
            //ask for optional second variable
            Console.WriteLine("Pick another number--optional");

            //if the user has entered the optional number
            try
            {
                //variable for the optional integer
                int data2 = Convert.ToInt32(Console.ReadLine());
                //results will be from both variables and method was called
                int result = m.Multiply(data, data2);
                Console.WriteLine(data+ " * " + data2 + " * 5 = " + result);
                Console.ReadLine();
            }

            //if the user does not enter optional number and default number
            catch
            {
                //results will be from only the first variable and method called, keeping default value
                int result = m.Multiply(data);
                Console.WriteLine(data + " * 2 * 5 = " + result);
                Console.ReadLine();
            }

            
            
            
         
           
        }
    }
}
