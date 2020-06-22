using FizzBuzzApp;
using NUnit.Framework;

namespace FizzBuzzTestsNamespace
{
    public class FizzBuzzShould
    {
        //[Test]
        //public void GivenOne_Return_OneString()
        //{
        //    Assert.That(Program.FizzBuzz(1), Is.EqualTo("1"));
        //}


        [TestCase(1, "1")]
        [TestCase(2, "2")]
        public void GivenANumber_Return_IsAsAString(int num, string expected)
        {
            Assert.That(Program.FizzBuzz(num), Is.EqualTo(expected));
        }

        //[Test]
        //public void GivenAThree_Return_Fizz()
        //{
        //    Assert.That(Program.FizzBuzz(3), Is.EqualTo("Fizz"));
        //}

        [TestCase(3, "Fizz")]
        public void GivenANumberDivisibleByThree_Return_Fizz(int num, string expected)
        {
            Assert.That(Program.FizzBuzz(num), Is.EqualTo(expected));
        }

        //[Test]
        //public void GivenFive_Return_Buzz()
        //{
        //    Assert.That(Program.FizzBuzz(5), Is.EqualTo("Buzz"));
        //}

        [TestCase(5, "Buzz")]
        public void GivenANumberDivisibleByFive_Return_Buzz(int num, string expected)
        {
            Assert.That(Program.FizzBuzz(num), Is.EqualTo(expected));
        }

        //[Test]
        //public void GivenFifteen_Return_FizzBuzz()
        //{
        //    Assert.That(Program.FizzBuzz(15), Is.EqualTo("FizzBuzz"));
        //}

        [TestCase(15, "FizzBuzz")]
        public void GivenANumberDivisibleByBothFiveAndThree_Return_FizzBuzz(int num, string expected)
        {
            Assert.That(Program.FizzBuzz(num), Is.EqualTo(expected));
        }



    }
}