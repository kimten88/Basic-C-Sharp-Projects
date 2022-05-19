using System;
using System.Collections.Generic;


namespace StringsIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //integer list
                List<int> numbers = new List<int> { 25, 10, 5, 75, 100, 90 };
                //asking for user input
                Console.WriteLine("Please enter a devisor: ");
                //set divisor as integer
                int divisor = Convert.ToInt32(Console.ReadLine());
                //for loop to go through each integer
                for (int i = 0; i < numbers.Count; i++)
                {
                    //telling program to divide list numbers by the user's divisor
                    int results = numbers[i] / divisor;
                    //displaying the results to the user
                    Console.WriteLine(numbers[i] + " divided by " + divisor + " equals " + results);
                }
                Console.ReadLine();
            }
            //gives the user better information on their errors
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number");
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero");
            }
            //catch all for any remaining errors
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
