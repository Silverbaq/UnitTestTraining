using NUnit.Framework;
using NUnit.Framework.Internal;
using UnitTestTraining.Exercise3;

namespace TestProject.Exercise3
{
    public class MyStringUtilTests
    {
        [Test]
        public void TestReverse()
        {
            // Arrange
            string input = "hello";

            // Act
            string result = MyStringUtil.Reverse(input);

            // Assert
            Assert.AreEqual("olleh", result);
        }

        [Test]
        public void TestIsPalindrome()
        {
            // Arrange
            string input1 = "racecar";
            string input2 = "hello";

            // Act
            bool result1 = MyStringUtil.IsPalindrome(input1);
            bool result2 = MyStringUtil.IsPalindrome(input2);

            // Assert
            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }

        [Test]
        public void TestCountOccurrences()
        {
            // Arrange
            string input = "hello world";

            // Act
            int result1 = MyStringUtil.CountOccurrences(input, 'l');
            int result2 = MyStringUtil.CountOccurrences(input, 'z');

            // Assert
            Assert.AreEqual(3, result1);
            Assert.AreEqual(0, result2);
        }

        [Test]
        public void TestRemoveWhitespace()
        {
            // Arrange
            string input = "hello world";

            // Act
            string result = MyStringUtil.RemoveWhitespace(input);

            // Assert
            Assert.AreEqual("helloworld", result);
        }
    }
}