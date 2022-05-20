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
            int number = 5;
            decimal decnum = 5.0m;
            string strNum = "5";
            int AddTotal = Math.Add(number);
            //displays results to the user
            Console.WriteLine(number + " plus 15 = " + AddTotal);
            //calling Subtract method from Math.cs
            int SubtractTotal = Math.Subtract(decnum);
            //displays results to the user
            Console.WriteLine(decnum + " minus 2 = " + SubtractTotal);
            //calling Divide method from Math.cs
            int MultiplyTotal = Math.Multiply(strNum);
            //displays results to the user
            Console.WriteLine(strNum + " times 10 = " + MultiplyTotal);
        }
    }
}
