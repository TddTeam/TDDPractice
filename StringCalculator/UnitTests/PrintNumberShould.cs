using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using SimpleApp;

namespace UnitTests
{
    [TestFixture]
    public class PrintNumberShould
    {
        private FormatNumber _formatNumber;

        [SetUp]
        public void Setup()
        {
            _formatNumber = new FormatNumber();
        }


        [TestCase(9)]
        [TestCase(6)]
        [TestCase(3)]
        public void ReturnHelloWhenTheNumberIsDivisibleByThree(int number)
        {
            //Assert
            string numberToString = _formatNumber.Print(number);

            //Act
            Assert.AreEqual("Hello", numberToString);
        }

        [TestCase(5)]
        [TestCase(10)]
        public void ReturnHelloWhenTheNumberIsDivisibleByFive(int number)
        {
            //Assert
            string numberToString = _formatNumber.Print(number);

            //Act
            Assert.AreEqual("Goodbye", numberToString);
        }

        [TestCase(15)]
        public void ReturnHelloGoodByeWhenTheNumberIsDivisibleByFiveAndThree(int number)
        {
            //Assert
            string numberToString = _formatNumber.Print(number);

            //Act
            Assert.AreEqual("HelloGoodbye", numberToString);
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        [TestCase(13)]
        public void ReturnActualNumberWhenTheNumberIsNotDivisibleByFiveAndIsNotDivisibleByThree(int number)
        {
            //Assert
            string numberToString = _formatNumber.Print(number);

            //Act
            Assert.AreEqual(number.ToString(), numberToString);
        }
    }
}
