using System;

namespace PrimeNumbers
{
    class Progran
    {
        static void Main(string[] args)
        {
            // Get the number from the user
            Console.WriteLine("Please enter a number you would like to check");

            int number = Convert.ToInt32(Console.ReadLine());

            // Divisors variable. Only a prime number when it has 2 divisibles
            int divisors = 0;

            // Loop over the number to increment the divsors
            for(int i = 1; i <= number; i++) { 
                if(number % i == 0)
                {
                    divisors++;
                }
            }

            // Log to the console based on the condition
            if(divisors == 2)
            {
                Console.WriteLine("The number is a prime number");
            }
            else
            {
                Console.WriteLine("The number is not a prime number!");
            }
        }
    }
}