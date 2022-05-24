using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace MethodSubmission2
{
    class MathMethod
    {
        //first method for user's numbers with 2 parameters 
        public int Multiply(int userValue, int userValue2=2)
        {

            //establish total as int value type, users number, and math operator
            int total = userValue * userValue2 * 5;
            return total;
          
        }
    }
}
