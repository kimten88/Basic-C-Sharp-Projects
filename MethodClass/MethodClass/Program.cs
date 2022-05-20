using System;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //gave the varaibles to use on program.cs
            int value1 = 5;
            int value2 = 7;
            //instantiated the class
            MathOperation m = new MathOperation();
            
            //calling the method and passing in the two numbers
            m.OperationMethod(value1, value2);

            //specifying the parameters by name
            m.OperationMethod(value1, value2);
            Console.WriteLine("Value1 is equal to: " + value1);
            Console.WriteLine("Value2 is qual to: " + value2);
        }
    }
}
