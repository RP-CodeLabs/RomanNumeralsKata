using NUnit.Framework;

namespace RomanNumeralsTests
{
    [TestFixture]
    public class RomanNumeralsTest
    {
        [TestCase("I", 1)]
        [TestCase("II",2)]
        [TestCase("III", 3)]
        [TestCase("IV", 4)]
        [TestCase("V", 5)]
        [TestCase("VI", 6)]
        [TestCase("VII", 7)]
        [TestCase("VIII", 8)]
        [TestCase("IX", 9)]
        [TestCase("X", 10)]
        [TestCase("XIII", 13)]
        [TestCase("XIV",14)]
        [TestCase("XV", 15)]
        [TestCase("XVIII", 18)]
        [TestCase("XIX", 19)]
        [TestCase("XXII", 22)]
        [TestCase("XXX", 30)]
        [TestCase("XXXIX", 39)]
        [TestCase("XL", 40)]
        [TestCase("XLIV", 44)]
        [TestCase("XLV", 45)]
        [TestCase("XLVIII", 48)]
        [TestCase("XLIX", 49)]
        [TestCase("L", 50)]
        [TestCase("LIV", 54)]
        [TestCase("LV", 55)]
        [TestCase("LVIII", 58)]
        [TestCase("LIX", 59)]
        [TestCase("LXIV", 64)]
        [TestCase("LXIX", 69)]
        [TestCase("LXXIV", 74)]
        [TestCase("LXXXIX", 89)]
        [TestCase("XC", 90)]
        [TestCase("XCIV", 94)]
        [TestCase("XCIX", 99)]
        [TestCase("C", 100)]

        public void convert_roman_numerals_to_number(string input, int expected)
        {
            var romanNumerals = new RomanNumerals();
            var result = romanNumerals.ConvertToNumber(input);
            Assert.That(result,Is.EqualTo(expected));
        }
    }
}
