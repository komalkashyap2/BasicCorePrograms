using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine($" Print prime factor of number is {i} ");
                }
            }
        }

        private static bool IsPrime(int number)
        {
            if (number <= 1) return false;  // prime numbers are greater than 1

            for (int i = 2; i < number; i++)
            {
                // only if is not a product of two natural numbers
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
