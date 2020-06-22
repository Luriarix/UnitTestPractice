using System;
using System.Collections.Generic;

namespace ProjectEuler_Multiples_of_3_and_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int max = 10;
            //for (int i = 0; i < max; i++)
            //{
            //    Console.WriteLine($"{SumOfMultiplesOfThreeAndFive(i)}");
            //}
            SumOfMultiplesOfThreeAndFive(10);
        }

        public static string SumOfMultiplesOfThreeAndFive(int n)
        {
            ////   return "3";//step 1
            //if (n % 3 == 0)//step 2
            //    return n.ToString();
            //else if (n % 5 == 0)//step 3 "n % 5 == 0"
            //    return n.ToString();
            //else
            //    return "It ain't a multiple of 3 or 5";//step 4 checks for both at a time

            //step 5 add the multiples of 3 or 5 together
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum.ToString();
        }
    }
}
