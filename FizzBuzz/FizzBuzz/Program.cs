using System;

namespace FizzBuzzApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int max = 50;
            for (int i = 1; i <= max; i++)
            {
                Console.WriteLine($"{FizzBuzz(i)}");
            }
        }
        public static string FizzBuzz(int n)
        {
            //baby (divisible by both) step 1: add a string var to store result
            string result = "";
            if (n % 3 == 0) //baby step 1 for divisible by 3: n == 3, step 2: n % 3 == 0
            {
                result += "Fizz";
            }
            /*baby (for divisible by 5) step 1: n == 5,
             *baby step 2: add else and n % 5 == 0,
             *baby step 3: remove else*/
            if (n % 5 == 0)
                result += "Buzz";

            if (result != "")
                return result;
            else
                return n.ToString();
        }
    }
}
