using System;
using System.Collections.Generic;

namespace ProjectEuler_Largest_prime_factor
{
    public class Program
    {
        static void Main(string[] args)
        {
            NumModulusZeroToPrimeNumber(13195);
        }

        public static bool IsNumPrime(int num)
        {
            for (int i = (num - 1); i > 1; i--)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static int NumModulusZeroToPrimeNumber(int num)
        {
            List<int> primeNumbersThatModulusTheNumber = new List<int>();
            int i;
            for (i = (num - 1); i > 1; i--)
            {
                if (num % i == 0)
                {
                    if (IsNumPrime(i) == true)
                    {
                        primeNumbersThatModulusTheNumber.Add(i);
                        //return i;
                    }
                }
            }
            return i;
        }

    }
}
