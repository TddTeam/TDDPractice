using System.Runtime.InteropServices.WindowsRuntime;
using NUnit.Framework;

namespace StringCalculator.Tests
{
    [TestFixture]
    public class StringCalculatorShould
    {
        [Test]
        public void ReturnZeroWhenStringIsEmpty()
        {
            var calculator = new Calculator();

            int expectedSum = calculator.CalculateFromString("");

            Assert.AreEqual(expectedSum, 0);
        }

        [Test]

        public void ReturnOneWhenStringIsOne()
        {
            var calculator = new Calculator();

            int expectedSum = calculator.CalculateFromString("1");

            Assert.AreEqual(expectedSum, 1);
        }

        [Test]

        public void ReturnTwoWhenStringIsTwo()
        {
            var calculator = new Calculator();

            int expectedSum = calculator.CalculateFromString("2");

            Assert.AreEqual(expectedSum, 2);
        }

        [Test]
        public void ReturnThreeWhenStringIsThree()
        {
            var calculator = new Calculator();

            int expectedSum = calculator.CalculateFromString("3");

            Assert.AreEqual(expectedSum, 3);
        }

        [TestCase("", 0)]
        [TestCase("1", 1)]
        [TestCase("2", 2)]
        public void ReturnIntegerValueOfString(string input, int result)
        {
            var calculator = new Calculator();

            int expectedSum = calculator.CalculateFromString(input);

            Assert.AreEqual(expectedSum, result);
        }
    }

    public class Calculator     
    {
        public int CalculateFromString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            return int.Parse(input);
        }
    }
}
