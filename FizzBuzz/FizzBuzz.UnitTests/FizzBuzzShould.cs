using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace FizzBuzz.UnitTests
{
    [TestFixture]
    public class FizzBuzzShould
    {
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(6, "Fizz")]
        [TestCase(10, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(99, "Fizz")]
        public void ReturnTheCorrectFizzBuzzConversion(int number, string expectedString)
        {
            var fizzBuzz = new FizzBuzz();

            var fizzBuzzOutput = fizzBuzz.Convert(number);

            Assert.That(fizzBuzzOutput, Is.EqualTo(expectedString));
        }
    }
}
