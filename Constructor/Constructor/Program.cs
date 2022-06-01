using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {

            Colors color = new Colors("Red", "Yellow", "Orange");

            //created a const variable
            const string color1 = "Deep Forest Green";
            //asks users for a color
            Console.WriteLine("Please enter your favorite color:");
            //using the var method
            var color2 = Console.ReadLine();


        }


    }

    
}
