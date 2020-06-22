using System;

namespace Even_Fibonacci_numbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            FibonacciSequence(10);
        }

        public static string FibonacciSequence(int num)
        {
            //return num.ToString();//initial

            ////step 1
            //int elementInTheSequence = 1, previousElementInSequence = 1;
            //while (elementInTheSequence < num)
            //{
            //    elementInTheSequence = previousElementInSequence + elementInTheSequence;
            //    previousElementInSequence = elementInTheSequence - previousElementInSequence;
            //};
            //return elementInTheSequence.ToString();

            //step 2
            int elementInTheSequence = 1, previousElementInSequence = 1, sumOfEvenElements = 0;
            while (elementInTheSequence <= num)
            {
                elementInTheSequence = previousElementInSequence + elementInTheSequence;
                previousElementInSequence = elementInTheSequence - previousElementInSequence;
                if (elementInTheSequence % 2 == 0)
                {
                    sumOfEvenElements += elementInTheSequence;
                }
            };
            return sumOfEvenElements.ToString();
        }
    }
}
