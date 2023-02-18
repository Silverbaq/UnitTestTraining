using NUnit.Framework;
using UnitTestTraining.Exercise2;

namespace TestProject.Exercise2
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void TestFizz()
        {
            // Arrange
            var number = 3;

            // Act
            var result = FizzBuzz.Convert(number);

            // Assert
            Assert.AreEqual("Fizz", result);
        }

        [Test]
        public void TestBuzz()
        {
            // Arrange
            int number = 5;

            // Act
            string result = FizzBuzz.Convert(number);

            // Assert
            Assert.AreEqual("Buzz", result);
        }

        [Test]
        public void TestFizzBuzz()
        {
            // Arrange
            int number = 15;

            // Act
            string result = FizzBuzz.Convert(number);

            // Assert
            Assert.AreEqual("FizzBuzz", result);
        }

        [Test]
        public void TestNumber()
        {
            // Arrange
            int number = 7;

            // Act
            string result = FizzBuzz.Convert(number);

            // Assert
            Assert.AreEqual(number.ToString(), result);
        }
    }
}