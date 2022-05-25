using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    //inherited from Person class and IQuittable interface
    public class Employee : Person, IQuittable
    {
        //implement the SayName() method 
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
        //void method quit
        public void Quit()
        {
            Console.WriteLine(FirstName + " " + LastName + " has left their position.");
        }
       
    }
}
