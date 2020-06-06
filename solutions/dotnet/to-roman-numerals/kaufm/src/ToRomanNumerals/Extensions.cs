using System;

namespace ToRomanNumerals
{
    public static class Extensions
    {
        public static string ToRomanNumerals(this int i)
        {
            if (i <= 0)
                return string.Empty;

            return "I";
        }
    }
}
