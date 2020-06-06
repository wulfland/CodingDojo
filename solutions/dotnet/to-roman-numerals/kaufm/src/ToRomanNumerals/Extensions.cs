using System;

namespace ToRomanNumerals
{
    public static class Extensions
    {
        public static string ToRomanNumerals(this int arabic)
        {
            var result = string.Empty;
            
            if (arabic <= 0)
                return result;

            if (arabic >= 5)
            {
                result = "V";
                arabic = arabic - 5;
            }

            if (arabic >= 4)
            {
                result += "IV";
                arabic = arabic - 4;
            }

            if (arabic >= 1)
            {
                for (int i = 0; i < arabic; i++)
                {
                    result += "I";
                }
            }

            return result;
        }
    }
}
