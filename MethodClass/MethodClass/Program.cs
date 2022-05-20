using System;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {

            //instantiated the class
            MathOperation m = new MathOperation();
            
            //calling the method and passing in the two numbers
            m.OperationMethod(5, 7);

            //specifying the parameters by name
            m.OperationMethod(value1: 3, value2: 20);
            
        }
    }
}
