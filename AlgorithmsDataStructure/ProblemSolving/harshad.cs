using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructure.ProblemSolving
{
    public class Harshad
    {
        // check if a number is a Harshad number
        private static bool IsHarshadNumber(int number)
        {
            int sumOfDigits = 0;
            int temp = number;

            // Calculate sum of digits
            while (temp > 0)
            {
                sumOfDigits += temp % 10;
                temp /= 10;
            }

            // Check if number is divisible by sum of digits
            return number % sumOfDigits == 0;
        }

        // find the nth Harshad number
        private static int FindNthHarshadNumber(int n)
        {
            int count = 0;
            int number = 1; // Start from 1

            while (true)
            {
                if (IsHarshadNumber(number))
                {
                    count++;
                    if (count == n)
                        return number; // Found nth Harshad number
                }

                number++; // Increment number to check the next one
            }
        }

        // Get a valid user input and find nth Harshad number
        public static void ProcessHarshadNumber()
        {
            int n;

            // Prompt user until they enter a valid positive integer
            while (true)
            {
                Console.Write("Enter a positive integer (n): ");
                string input = Console.ReadLine();

                // Validate user input
                if (int.TryParse(input, out n) && n > 0)
                {
                    break; // Valid input, exit loop
                }

                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }

            // Compute the nth Harshad number
            int result = FindNthHarshadNumber(n);

            // Output result
            Console.WriteLine($"The {n}th Harshad number is: {result}");
        }
    }
}
