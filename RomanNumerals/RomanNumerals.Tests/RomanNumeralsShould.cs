using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace RomanNumerals.Tests
{
    [TestFixture]
    public class RomanNumeralsShould
    {
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4,"IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        [TestCase(11, "XI")]
        [TestCase(12, "XII")]
        [TestCase(13, "XIII")]
        [TestCase(14, "XIV")]
        public void ReturnRomanNumeralForNumber(int number, string numeral)
        {
            var romanNumeralsConvertor = new RomanNumeralsConvertor();

            var result = romanNumeralsConvertor.Convert(number);

            Assert.AreEqual(numeral, result);
        }
    }
}

public class RomanNumeralsConvertor
{
    public string Convert(int number)
    {
        var numerals = new Dictionary<int, char> { {10, 'X'}, {5, 'V'}, {1, 'I'}};

        string romanNumeral = "";

        for (int i = number; i > 0; i--)
        {
            foreach (var numeral in numerals)
            {
                if (i % numeral.Key == 0)
                {
                    romanNumeral = numeral.Value + romanNumeral;

                    i -= numeral.Key - 1;

                    break;
                }

                if (i == numerals[10] )
                {
                    romanNumeral = "IV";

                    i = 0;

                    break;
                }

                if (i == numeral.Key - 1)
                {
                    romanNumeral = numerals[1].ToString() + numeral.Value;

                    i = 0;

                    break;
                }
            }
        }
        
        return romanNumeral;
    }
}

