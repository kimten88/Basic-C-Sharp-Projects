using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //instantiate employee class
                Employee emp1 = new Employee();
                //establish name Sample Student
                emp1.FirstName = "Sample";
                emp1.LastName = "Student";
                emp1.id = 1;

                //instantiate employee class
                Employee emp2 = new Employee();
                //establish name Sample Student
                emp2.FirstName = "Next";
                emp2.LastName = "Example";
                emp2.id = 2;


                //calling SayName method
                emp1.SayName();
                emp2.SayName();
                //comparing employee ids
                Console.WriteLine(emp1 == emp2);

            }
        }
    }
}
