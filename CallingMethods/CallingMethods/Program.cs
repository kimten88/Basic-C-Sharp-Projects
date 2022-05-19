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
            Console.WriteLine("Please indicate a number: ");
            string chNum = Console.ReadLine();
            int chosenNum = Convert.ToInt32(chNum);
            int MultiTotal = Math.Multiply(chosenNum);
            Console.WriteLine( chosenNum + " times 5 = " + MultiTotal);
            int AddTotal = Math.Add(chosenNum);
            Console.WriteLine(chosenNum + " plus 10 = "  + AddTotal);
            int DivideTotal = Math.Divide(chosenNum);
            Console.WriteLine(chosenNum + " divided by 2 = " + DivideTotal);
        }


    }


}
