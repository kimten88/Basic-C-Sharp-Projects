﻿using System;

namespace ParsingEnums
{
    class Program
    {
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {


            try
            {
                Console.WriteLine("What day is it?");
                string userAnswer = Console.ReadLine();
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userAnswer);
                Console.WriteLine(day + " is today!");

            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an acutal day of the week");
            }
            Console.ReadLine();
        }
    }
}