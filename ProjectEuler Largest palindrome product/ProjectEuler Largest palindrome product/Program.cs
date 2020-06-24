using System;

namespace ProjectEuler_Largest_palindrome_product
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProducOfThreeDigitNumbers();
        }


        public static bool PalindromCheck(int num)
        {
            //return 1; //step 1

            //step 2
            string valueCheck = num.ToString();
            bool isPalindrom = true;
            for (int i = 0; i < num.ToString().Length; i++)
            {
                int j = (num.ToString().Length - 1) - i;
                if (valueCheck[i] == valueCheck[j])
                {
                    isPalindrom = true;
                }
                else
                {
                    isPalindrom = false;
                    break;
                }
            }
            return isPalindrom;
        }

        public static long ProducOfThreeDigitNumbers(/*int num1, int num2*/)
        {
            //return num1 * num2;//step 3

            for (int i = 999; i > 100; i--)
            {
                for (int j = 999; j > 100; j--)
                {
                    if (PalindromCheck(i * j) == true)
                    {
                        long result = i * j;
                        Console.WriteLine(result);
                        return result; 
                    }
                }
            }
            return 0;
        }

    }
}
