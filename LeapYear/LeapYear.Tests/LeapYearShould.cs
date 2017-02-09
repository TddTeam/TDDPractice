using System;
using NUnit;
using NUnit.Framework;

namespace LeapYear.Tests
{
    [TestFixture]
    public class LeapYearShould
    {
        public LeapYearValidator LeapYearValidator { get; set; }
        [SetUp]
        public void Setup()
        {
            this.LeapYearValidator = new LeapYearValidator();
        }

        [TestCase(2000)]
        [TestCase(1996)]
        [TestCase(2004)]
        [TestCase(6000)]
        [TestCase(4000)]
       
       
        public void ReturnTrueForALeapYear(int year)
        {
            int testValue = year;
            
            var result = LeapYearValidator.LeapYear(testValue);

            Assert.IsTrue(result);
        }

         [TestCase(2001)]
         [TestCase(1000)]
         [TestCase(100)]
        public void ReturnFalseForACommonYear(int year)
        {
            var result = LeapYearValidator.LeapYear(year);

            Assert.IsFalse(result);
        }

        [Test]
        public void ReturnFalseForAnAtypicalYear()
        {
            int testValue = 1900;

            var result = LeapYearValidator.LeapYear(testValue);

            Assert.IsFalse(result);
        }
    }
}
