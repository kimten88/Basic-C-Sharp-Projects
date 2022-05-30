using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //created a const variable
            const string colorName = "Deep Forest Green";
            //asks users for a color
            Console.WriteLine("Please enter your favorite color:");
            //using the var method
            var userAnswer = Console.ReadLine();
            //chaining 
            string newColor = colorName + userAnswer;

            //displaying the information to the user
            Console.WriteLine("While your favorite color is: " + userAnswer + "\nMy Favorite color is {0}! ", colorName + "\nI would like to see a new color called " + newColor);
            Console.ReadLine();
        }
    }
}
