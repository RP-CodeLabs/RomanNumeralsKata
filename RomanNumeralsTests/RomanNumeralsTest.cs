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
        [TestCase("XXXIX", 39)]

        public void convert_roman_numerals_to_number(string input, int expected)
        {
            var romanNumerals = new RomanNumerals();
            var result = romanNumerals.ConvertToNumber(input);
            Assert.That(result,Is.EqualTo(expected));
        }
    }
}
