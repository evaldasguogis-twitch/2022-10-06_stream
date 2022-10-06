// Read https://en.wikipedia.org/wiki/Fizz_buzz

/*
Write a program that prints the integers from 1 to 100 (inclusive).
But:
 for multiples of three, print Fizz (instead of the number)
 for multiples of five, print Buzz (instead of the number)
 for multiples of both three and five, print FizzBuzz (instead of the number)
*/

//NOTES: breakpoints, autos/local, conditional breakpoints

namespace _01_fizzbuzz_debugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();

            // Expected Output:
            // 1
            // 2
            // Fizz
            // 4
            // Buzz
            // Fizz
            // 7
            // 8
            // Fizz
            // Buzz
            // 11
            // Fizz
            // 13
            // 14
            // FizzBuzz
            // 16
            // 17
            // ...
        }
    }
}