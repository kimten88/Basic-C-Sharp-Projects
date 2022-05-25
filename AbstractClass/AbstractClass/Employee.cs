using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    //inherited from Person class
    public class Employee : Person
    {
        //implement the SayName() method 
        public override void SayName()
         {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
}
}
