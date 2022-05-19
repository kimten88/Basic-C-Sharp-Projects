using System;
using System.Collections.Generic;
using System.Text;

namespace CallingMethods
{
    public static class Math
    {

        public static int Multiply(int chosenNum)
        {

            int total = chosenNum * 5;
            return total;
           
        }

        public static int Add(int chosenNum)
        {

            int total = chosenNum + 10;
            return total;

        }

        public static int Divide(int chosenNum)
        {

            int total = chosenNum / 2;
            return total;

        }

    }
   
}
    
