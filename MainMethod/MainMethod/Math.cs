using System;
using System.Collections.Generic;
using System.Text;

namespace MainMethod
{
    public class Math
    {
        public int Operations(int number = 5)
        {
            //establish total as int value type, users number, and math operator
            int total = number + 15;
            return total;
        }

        public int Operations(decimal decnum = 5.0m)
        {
            //converting to integer
            int decNumCon = Convert.ToInt32(decnum);
            //establish total as int value type, users number, and math operator
            int total = decNumCon - 2;
            return total;
        }

        public int Operations(string strNum = "5")
        {
            //converting to integer
            int stringNum = Convert.ToInt32(strNum);
            //establish total as int value type, users number, and math operator
            int total = stringNum * 10;
            return total;

        }

    }
}
