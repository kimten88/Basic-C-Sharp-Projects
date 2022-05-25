using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate employee class
            Employee employee = new Employee();
            //establish name Sample Student
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            //calling SayName method
            employee.SayName(); 

        }
    }
}
