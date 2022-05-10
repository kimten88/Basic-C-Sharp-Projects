using System;

namespace WhileDoStatements
{
    class Program
    {
        static void Main()
        {
            //user is ask to guess the animal, animal is assigned as elephant
            Console.WriteLine("Guess the zoo animal?");
            string animal = Console.ReadLine();
            bool isGuessed = animal == "elephant";

            //the loop runs even if user gets it in first attempt
            do
            {   //animal is the variable being evaluated
                switch (animal)
                {
                    //if the user types in tiger the program allows them to try again
                    case "tiger":
                        Console.WriteLine("You guessed tiger. Try again.");
                        Console.WriteLine("Guess the zoo animal?");
                        animal = Console.ReadLine();
                        break;
                    case "monkey":
                        Console.WriteLine("You guessed monkey. Try again");
                        Console.WriteLine("Guess the zoo animal?");
                        animal = Console.ReadLine();
                        break;
                    case "ostrich":
                        Console.WriteLine("You guessed ostrich. Try again");
                        Console.WriteLine("Guess the zoo animal?");
                        animal = Console.ReadLine();
                        break;
                    //user guesses it correctly, the boolean is now true and the program ends
                    case "elephant":
                        Console.WriteLine("You guessed elephant. That is correct!");
                        isGuessed = true;
                        break;
                    //user guesses any other animal
                    default:
                        Console.WriteLine("You are wrong");
                        Console.WriteLine("Guess the zoo animal?");
                        animal = Console.ReadLine();
                        break;
                }
            }
            //the loop which will not stop untill the boolean becomes true
            while (!isGuessed);
            {
            }
            Console.Read();

            int num = 0;
            while (num < 10)
            {
                Console.WriteLine(num);
                num++;
                Console.ReadLine();
            }
        }
    }
}
