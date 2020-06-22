using NUnit.Framework;
using System.Collections.Generic;

namespace AdvancedNUnit
{
    public class Tests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void Add_Always_ReturnsExpectedResult()
        {
            // Arrange
            var subject = new Calculator();
            // Act
            var result = subject.Add(2, 4);
            // Assert
            Assert.AreEqual(6, result);
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void DivisibleBy3_Always_ReturnsExpectedResult()
        {
            var subject = new Calculator();
            Assert.That(subject.DivisibleBy3(6));
        }

        [Test]
        public void DivisibleBy3_ReturnsFalse()
        {
            var subject = new Calculator();
            Assert.That(subject.DivisibleBy3(7), Is.False);
        }


        [Test]
        public void Class_Contains()
        {
            var subject = new Calculator();
            Assert.That(subject.ToString(), Does.Contain("Calculator"));
        }

        [Test]
        public void DividingByZero()
        {
            var subject = new Calculator();
            Assert.That(() => subject.Divide(5, 0), Throws.ArgumentException);
            Assert.That(() => subject.Divide(5, 0), Throws.ArgumentException.With.Message.EqualTo("Can't divide by 0"));
        }

        [Test]
        public void StringConstraints()
        {
            var subject = new Calculator();
            var strResult = subject.ToString();
            Assert.That(strResult, Does.Contain("Calculator"));
            Assert.That(strResult, Does.Not.Contain("Potato"));
            Assert.That(strResult, Is.EqualTo("AdvancedNUnit.Calculator"));
            Assert.That(strResult, Is.EqualTo("advancednunit.calculator").IgnoreCase);
            Assert.That(strResult, Is.Not.Empty);
        }

        [Test]
        public void CollectionConstraints()
        {
            var fruit = new List<string>
            {
                "apple","pear","banana","peach"
            };
            Assert.That(fruit, Does.Contain("pear"));
            Assert.That(fruit, Has.Count.EqualTo(4));
            Assert.That(fruit, Has.Exactly(2).StartsWith("pea"));
        }

        [Test]
        public void RangeConstraint()
        {
            Assert.That(8, Is.InRange(1, 10));
            List<int> nums = new List<int> { 4, 2, 7, 5, 9 };
            Assert.That(nums, Is.All.InRange(1, 10));
        }



    }
}