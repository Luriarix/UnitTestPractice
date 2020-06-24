using NUnit.Framework;
using Even_Fibonacci_numbers;

namespace EvenFibonacciNumbersNUnitTest
{
    public class Tests
    {
        [Test]//initial Given 1 return 1
        public void GivenOne_Return_OneString()
        {
            Assert.That(Program.FibonacciSequence(1), Is.EqualTo("1"));
        }

        [Test]//test 1 starting the sequence and showing it's last elements, given 2 return 2
        public void GivenTwo_Return_LastElement()
        {
            Assert.That(Program.FibonacciSequence(2), Is.EqualTo("2"));
        }

        [TestCase(10, "10")]//test 2 sum of sequence of even numbers
        [TestCase(40, "44")]
        [TestCase(1000, "798")]
        public void GivenTen_Return_SumOfEvenElements(int num, string expected)
        {
            Assert.That(Program.FibonacciSequence(num), Is.EqualTo(expected));
        }


    }
}