// Create a function that takes an integer as an argument and returns "Even" 
// for even numbers or "Odd" for odd numbers.

using System;

namespace EvenOrOdd
{
    class Program
    {
        public class SolutionClass
        {
            public static string EvenOrOdd(int number) => (number % 2 == 0) ? "Even" : "Odd";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
