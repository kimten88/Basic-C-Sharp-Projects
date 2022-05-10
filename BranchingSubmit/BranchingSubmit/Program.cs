using System;

namespace BranchingSubmit
{
    class Program
    {
        static void Main(string[] args)
        {
            //welcoming the customer and asking for the weight of their package
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.WriteLine("Please enter the package weight: ");
            int weight = int.Parse(Console.ReadLine());
            //if statement to see if the weight qualifies to be taken by this company
            if (weight > 50)
            {
                //if it is too heavy this message will display and the program will end
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day");
                Console.ReadLine();
            }
            //else is put in place so the program can continue if contraints are allowed
            else
            {
                //asking customer to provide mesurments for the package
                Console.WriteLine("Please enter the package width: ");
                int width = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the package height: ");
                int height = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the package length: ");
                int length = int.Parse(Console.ReadLine());
                //total is needed to see if company can ship
                int total = width + height + length;
                //does the package fall within in the physical constraints
                if (total > 50)
                {
                    //if it is too big the customer will see this message and the program will stop
                    Console.WriteLine("Package is too big to be shipped via Package Express");
                }
                //program will continue if the package fits within the constraints
                else
                {
                    //performing calculations to give customer a quote
                    int product = width * height * length * weight;
                    int quote = product / 100;
                    //converting the amount to currency
                    String quoteDollars = quote.ToString("C");
                    //telling the customer the quote
                    Console.WriteLine("Your estimated total for shipping this package is: " + quoteDollars);
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                }

            }
        }
    }
}
