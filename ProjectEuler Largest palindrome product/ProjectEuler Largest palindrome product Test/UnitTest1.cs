using NUnit.Framework;
using ProjectEuler_Largest_palindrome_product;

namespace ProjectEuler_Largest_palindrome_product_Test
{
    public class Tests
    {
        //[Test]//initial Given 1 return 1 
        //public void Test1()
        //{
        //    Assert.That(Program.PalindromCheck(1), Is.EqualTo(1));
        //}

        [TestCase(212, true)]//test 1 check to see if a number is a palindrom 
        [TestCase(636, true)]
        [TestCase(525, true)]
        public void PalindromCheck_Result_IsPalindrom(int num, bool expected)
        {
            Assert.That(Program.PalindromCheck(num), Is.EqualTo(expected));
        }

        [TestCase(123, false)]
        public void PalindromCheck_Result_NotAPalindrom(int num, bool expected)
        {
            Assert.That(Program.PalindromCheck(num), Is.EqualTo(expected));
        }



        //[TestCase(12,24)]//test 2 check product 
        //[TestCase(2,6)]
        //[TestCase(3, 5)]
        //public void ProducOfNumbers_Resul_Product(int num1, int num2)
        //{
        //    Assert.That(Program.ProducOfThreeDigitNumbers(num1, num2), Is.EqualTo(num1 * num2));
        //}

        [Test]//test 3 check if the product of the two three digit numbers is a palindrom
        public void ProducOfThreeDigitNumbers_Resul_Palindrom()
        {
            var result = Program.ProducOfThreeDigitNumbers();
            Assert.That(Program.ProducOfThreeDigitNumbers(), Is.EqualTo(result));
        }

    }
}