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

            int result = calculator.CalculateFromString("");

            Assert.AreEqual(0, result);
        }

        [Test]

        public void ReturnOneWhenStringIsOne()
        {
            var calculator = new Calculator();

            int result = calculator.CalculateFromString("1");

            Assert.AreEqual(1, result);
        }

        [Test]

        public void ReturnTwoWhenStringIsTwo()
        {
            var calculator = new Calculator();

            int result = calculator.CalculateFromString("2");

            Assert.AreEqual(2, result);
        }

        [Test]
        public void ReturnThreeWhenStringIsThree()
        {
            var calculator = new Calculator();

            int result = calculator.CalculateFromString("3");

            Assert.AreEqual(3, result);
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

        [TestCase("1,2", 3)]
        [TestCase("2,2", 4)]
        [TestCase("200,245,3", 448)]
        [TestCase("200\n245,3", 448)]
        [TestCase("200\n245\n3", 448)]
        public void ReturnSumWhenStringIsADelimitedListOfNumbers(string input, int expected)
        {
            var calculator = new Calculator();

            int result = calculator.CalculateFromString(input);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ReturnThreeWithSpecifiedDelimiter()
        {
            var calculator = new Calculator();

            int result = calculator.CalculateFromString("//;\n1;2");

            Assert.AreEqual(3, result);
        }

        [Test]
        public void ReturnFourWithSpecifiedDelimiter()
        {
            var calculator = new Calculator();

            int result = calculator.CalculateFromString("//+\n2+2");

            Assert.AreEqual(4, result);
        }
    }
}
