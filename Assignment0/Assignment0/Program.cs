using System;

namespace Assignment0
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Methods LeapYear = new Methods();

            Console.Write("Enter year: ");

            int userInput = Convert.ToInt32(Console.ReadLine());

            LeapYear.IsLeapYear(userInput);
            


        }

    }
}

