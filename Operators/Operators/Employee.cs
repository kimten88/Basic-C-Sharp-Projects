using System;
using System.Collections.Generic;
using System.Text;

namespace Operators
{

    public class Employee : Person, IQuittable
    {
        //property with int value called ID
        public int id { get; set; }

         //implement the SayName() method 
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName + " ID = " + id);
        }
        //void method quit
        public void Quit()
        {
            Console.WriteLine(FirstName + " " + LastName + " has left their position.");
        }
        
        //overload the == operator if employee ids match
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            return emp1.id == emp2.id;
        }
        //checks to see if the ids are not equal
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return emp1.id != emp2.id;
        }








    }
    
}
