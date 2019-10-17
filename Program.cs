using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // FizzBuzz
            // Print values between 1 and whatever number the user chooses
            // If the value is dividable by 3, write Fizz instead. If it's dividable by 5, write Buzz. If by both, write FuzzBuzz
            Console.Write("Welcome to FizzBuzz, please enter the highest value you want to use: ");
            string selection = Console.ReadLine();
            int endval = 0;
            // While loop that checks the user for a valid value. Only exif if the given value is a valid integer
            while (true)
            {
                if (int.TryParse(selection, out endval) && endval > 0)
                {
                    break;
                }
                else
                {
                    Console.Write("Please enter a valid number! ");
                    selection = Console.ReadLine();
                }
            }
            // Use for loop to print values between 1 and the selected number.
            for (int i = 1; i <= endval; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Finished. Press any key to exit");
            Console.ReadKey();
        }
    }
}