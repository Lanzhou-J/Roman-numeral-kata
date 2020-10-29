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
        
        [Theory]
        [InlineData("II", 2)]
        [InlineData("III", 3)]
        public void ToRomanNumeralShould_ReturnCorrectValue_WhenInputSingleNumberInt(string expected, int input)
        {
            var result = RomanNumeralGenerator.ToRomanNumeral(input);
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void ToRomanNumeralShould_ReturnV_WhenInput5()
        {
            var result = RomanNumeralGenerator.ToRomanNumeral(5);
            Assert.Equal("V", result);
        }
        
        [Fact]
        public void ToRomanNumeralShould_ReturnX_WhenInput10()
        {
            var result = RomanNumeralGenerator.ToRomanNumeral(10);
            Assert.Equal("X", result);
        }

    }
}