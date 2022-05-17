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
                Console.WriteLine("Please enter a devisor: ");
                int divisor = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < numbers.Count; i++)
                {
                    int results = numbers[i] / divisor;
                    Console.WriteLine(numbers[i] + " divided by " + divisor + " equals " + results);
                }
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number");
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero");
            }
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
