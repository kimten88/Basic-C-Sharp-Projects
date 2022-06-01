using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    public class Colors
    {
        public string color1;
        public string color2;
        public string color3;
        //chainning contructs
        public Colors(string color1) : this(color1, " blue ")
        {

        }
        //chaining contructs
        public Colors(string color1, string color2) : this(color1, color2, " red ") 
        {

        }

        public Colors(string color1, string color2, string color3)
        {
            this.color1 = color1;
            this.color2 = color2;
            this.color3 = color3;
        }

    }
}
