using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public abstract class Person
    {
        //property First Name of class Person
        public string FirstName { get; set; }

        //property Last Name of class Person
        public string LastName { get; set; }

        //abstract void method which displays person's name without parameters
        public abstract void SayName();

    }
}
