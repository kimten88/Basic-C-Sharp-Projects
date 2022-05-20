using System;
using System.Collections.Generic;
using System.Text;

namespace MethodClass
{
    public class MathOperation
    {
        //created void method with two numbers
        public void OperationMethod (int value1, int value2)
        {

            //method doing the math operation with first integer
            int total = value1 * 2;
            Console.WriteLine(value1 + " * 2 = " + total);
            //displaying second integer
            Console.WriteLine("Value 2 = " + value2);
        }
    }
}
