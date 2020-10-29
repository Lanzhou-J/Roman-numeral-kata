namespace RomanNumeralKata
{
    public static class RomanNumeralGenerator
    {
        public static string ToRomanNumeral(int number)
        {
            var romanNumeral = "";
            if (number == 5)
            {
                romanNumeral = "V";
                return romanNumeral;
            }
            if (number == 10)
            {
                romanNumeral = "X";
                return romanNumeral;
            }
            while (number > 0)
            {
                romanNumeral += "I";
                number -= 1;
            }
            return romanNumeral;
        }
    }
}