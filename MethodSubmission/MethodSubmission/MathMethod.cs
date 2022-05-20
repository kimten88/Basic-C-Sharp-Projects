using System;
using System.Collections.Generic;
using System.Text;

namespace MethodSubmission
{
    public static class MathMethod
    {
        //first method for user's number with chosenNum parameter 
        public static int Multiply(int userValue, int userValue2)
        {
            //establish total as int value type, users number, and math operator
            int total = userValue * userValue2 * 5;
            return total;

        }

        public static int Multiply(int userValue)
        {
            //establish total as int value type, users number, and math operator
            int total = userValue * 5;
            return total;

        }

        //second method for user's number with chosenNum parameter 
        public static int Add(int userValue, int userValue2)
        {
            //establish total as int value type, users number, and math operator
            int total = userValue + userValue2 + 10;
            return total;

        }

        public static int Add(int userValue)
        {
            //establish total as int value type, users number, and math operator
            int total = userValue + 10;
            return total;

        }

        //third method for user's number with chosenNum parameter 
        public static int Subtract(int userValue, int userValue2)
        {
            //establish total as int value type, users number, and math operator
            int total = userValue - userValue2 - 2;
            return total;

        }

        public static int Subtract(int userValue)
        {
            //establish total as int value type, users number, and math operator
            int total = userValue -  2;
            return total;

        }
    }
}
