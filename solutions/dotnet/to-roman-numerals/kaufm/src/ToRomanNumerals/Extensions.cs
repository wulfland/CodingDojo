using System;

namespace ToRomanNumerals
{
    public static class Extensions
    {
        public static string ToRomanNumerals(this int arabic)
        {
            if (arabic <= 0)
                return string.Empty;

            var result = "I";

            for (int i = 1; i < arabic; i++)
            {
                result += "I";
            }

            return result;
        }
    }
}
