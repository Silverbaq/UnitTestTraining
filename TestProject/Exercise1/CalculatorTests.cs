using NUnit.Framework;
using UnitTestTraining.Exercise1;

namespace TestProject.Exercise1
{
    [TestFixture]
    public class CalculatorTests
    {
        private readonly Calculator _calculator = new Calculator();

        [Test]
        public void CalculatorCanAdd()
        {
            var a = 0.3;
            var b = 1.4;

            var expected = a + b;
            var actual = _calculator.Add(a, b);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CalculatorCanSub()
        {
            var a = 0.3;
            var b = 1.4;

            var expected = a - b;
            var actual = _calculator.Sub(a, b);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CalculatorCanMulti()
        {
            var a = 0.3;
            var b = 1.4;

            var expected = a * b;
            var actual = _calculator.Multi(a, b);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CalculatorCanDiv()
        {
            var a = 0.3;
            var b = 1.4;

            var expected = a / b;
            var actual = _calculator.Div(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}