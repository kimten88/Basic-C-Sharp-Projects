using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating object type IQuittable
            IQuittable quittable = new Employee();
            //calling quit method 
            quittable.Quit();

        }
    }
}
