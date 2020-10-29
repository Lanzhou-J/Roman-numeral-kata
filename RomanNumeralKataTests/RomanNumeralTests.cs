using RomanNumeralKata;
using Xunit;

namespace RomanNumeralKataTests
{
    public class RomanNumeralTests
    {
        [Fact]
        public void ToRomanNumeralShould_ReturnEmptyString_WhenInput0()
        {
            var result = RomanNumeralGenerator.ToRomanNumeral(0);
            Assert.Equal("", result);
        }
        
        [Fact]
        public void ToRomanNumeralShould_ReturnI_WhenInput1()
        {
            var result = RomanNumeralGenerator.ToRomanNumeral(1);
            Assert.Equal("I", result);
        }
    }
}