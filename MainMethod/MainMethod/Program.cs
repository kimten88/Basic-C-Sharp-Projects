using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            //each variable deturmined
            int number = 5;
            decimal decnum = 5.0m;
            string strNum = "5";
            //creating an object named m of class Math
            Math m = new Math();
            
            //calling method
            int total = m.Operations(number);
            //displays results to the user
            Console.WriteLine(number + " plus 15 = " + total);
            
            //calling method from Math.cs
            total = m.Operations(decnum);
            //displays results to the user
            Console.WriteLine(decnum + " minus 2 = " + total);
           

            //calling method from Math.cs
            total = m.Operations(strNum);
            //displays results to the user
            Console.WriteLine(strNum + " times 10 = " + total);
            
        }
    }
}
