using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsObjects
{
    public class Person
    {
        //property First Name of class Person
        public string FirstName { get; set; }

        //property Last Name of class Person
        public string LastName { get; set; }

        //void method which displays person's name without parameters
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
