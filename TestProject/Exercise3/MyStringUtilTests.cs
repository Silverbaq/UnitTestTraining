using NUnit.Framework;
using UnitTestTraining.Exercise3;

namespace TestProject.Exercise3
{
    public class MyStringUtilTests
    {
        [Test]
        public void TestReverse()
        {
            // Arrange
            var input = "hello";

            // Act
            var result = MyStringUtil.Reverse(input);

            // Assert
            Assert.AreEqual("olleh", result);
        }

        [Test]
        public void TestIsPalindrome()
        {
            // Arrange
            var input1 = "racecar";
            var input2 = "hello";

            // Act
            var result1 = MyStringUtil.IsPalindrome(input1);
            var result2 = MyStringUtil.IsPalindrome(input2);

            // Assert
            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }

        [Test]
        public void TestCountOccurrences()
        {
            // Arrange
            var input = "hello world";

            // Act
            var result1 = MyStringUtil.CountOccurrences(input, 'l');
            var result2 = MyStringUtil.CountOccurrences(input, 'z');

            // Assert
            Assert.AreEqual(3, result1);
            Assert.AreEqual(0, result2);
        }

        [Test]
        public void TestRemoveWhitespace()
        {
            // Arrange
            var input = "hello world";

            // Act
            var result = MyStringUtil.RemoveWhitespace(input);

            // Assert
            Assert.AreEqual("helloworld", result);
        }
    }
}