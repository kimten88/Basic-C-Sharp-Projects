using System;
using System.Collections.Generic;
using System.Text;

namespace CallingMethods
{
    //class called Math
    public static class Math
    {
        //first method for user's number with chosenNum parameter 
        public static int Multiply(int chosenNum)
        {
            //establish total as int value type, users number, and math operator
            int total = chosenNum * 5;
            return total;
           
        }

        //second method for user's number with chosenNum parameter 
        public static int Add(int chosenNum)
        {
            //establish total as int value type, users number, and math operator
            int total = chosenNum + 10;
            return total;

        }

        //third method for user's number with chosenNum parameter 
        public static int Divide(int chosenNum)
        {
            //establish total as int value type, users number, and math operator
            int total = chosenNum / 2;
            return total;

        }

    }
   
}
    
