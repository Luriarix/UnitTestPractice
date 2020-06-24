using NUnit.Framework;
using ProjectEuler_Largest_prime_factor;

namespace ProjectEuler_Largest_prime_factor_Test
{
    public class Tests
    {
        [TestCase(2, true)]// initial check if num is prime
        [TestCase(3, true)]
        [TestCase(4, false)]
        [TestCase(5, true)]
        [TestCase(6, false)]
        [TestCase(7, true)]
        public void CheckIfNumIsPrime_Result_True(int num, bool result)
        {
            Assert.That(Program.IsNumPrime(num), Is.EqualTo(result));
        }

        [TestCase(13195)]//step 1 check what num module exact
        [TestCase(12345)]
        [TestCase(25)]
        [TestCase(2)]
        public void CheckIfNumHasPrimeNumbersThatGiveModulusZero_Result_True(int num)
        {
            var result = Program.NumModulusZeroToPrimeNumber(num);
            Assert.That(Program.NumModulusZeroToPrimeNumber(num), Is.EqualTo(result));
        }

    }
}