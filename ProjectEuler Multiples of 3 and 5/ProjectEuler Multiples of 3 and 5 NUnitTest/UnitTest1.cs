using NUnit.Framework;
using ProjectEuler_Multiples_of_3_and_5;

namespace ProjectEuler_Multiples_of_3_and_5_NUnitTest
{
    public class Tests
    {
        //[Test]//initial test
        //public void GivenThree_Return_ThreeString()
        //{
        //    Assert.That(Program.SumOfMultiplesOfThreeAndFive(3), Is.EqualTo("3"));
        //}

        //[TestCase(3, "3")]// test 1 check for if multiple or 3
        //[TestCase(6, "6")]
        //[TestCase(9, "9")]
        //public void GivenAMultipleOfThree_Return_NumberString(int num, string expected)
        //{
        //    Assert.That(Program.SumOfMultiplesOfThreeAndFive(num), Is.EqualTo(expected));
        //}

        //[Test]//test 2 check if 5
        //public void GivenFive_Return_FiveString()
        //{
        //    Assert.That(Program.SumOfMultiplesOfThreeAndFive(5), Is.EqualTo("5"));
        //}

        //[TestCase(5, "5")]//test 3 check if multiple of 5
        //public void GivenAMultipleOfFive_Return_NumberString(int num, string expected)
        //{
        //    Assert.That(Program.SumOfMultiplesOfThreeAndFive(num), Is.EqualTo(expected));
        //}

        //[TestCase(5, "5")]//test 4 check if multiple of 5 and 3
        //[TestCase(3, "3")]
        //[TestCase(6, "6")]
        //[TestCase(9, "9")]
        //public void GivenAMultipleOfThreeOrFive_Return_NumberString(int num, string expected)
        //{
        //    Assert.That(Program.SumOfMultiplesOfThreeAndFive(num), Is.EqualTo(expected));
        //}

        [TestCase(10, "33")]//test 5 check if multiple of 5 and 3
        [TestCase(1000, "234168")]
        public void GivenAMultipleOfThreeOrFive_Return_SumString(int num, string expected)
        {
            Assert.That(Program.SumOfMultiplesOfThreeAndFive(num), Is.EqualTo(expected));
        }
    }
}