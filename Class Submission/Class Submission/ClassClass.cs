using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Submission
{
    static class ClassClass
    {

        public static void Divide(int userValue, out int total)
        {

            //establish total as userValue divided by 2
            total = userValue / 2;
            

        }
        //overload this method
        public static int Multiply(int userValue)
        {
            int result = userValue * 10;
            return result;

        }
        public static int Multiply(int userValue, int userValue2)
        {
            int result = userValue * userValue2 *10;
            return result;

        }

    }
}
