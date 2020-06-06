using System;
using System.Collections.Generic;
using System.Linq;

namespace ToRomanNumerals
{
    public static class Extensions
    {
        static IDictionary<int, string> constants = new Dictionary<int, string>
        {
            { 1, "I" },
            { 4, "IV" },
            { 5, "V" }
        };

        public static string ToRomanNumerals(this int arabic)
        {
            var result = string.Empty;
            
            if (arabic <= 0)
                return result;

            foreach (var item in constants.Reverse())
            {
                if (arabic >= item.Key)
                {
                    result += item.Value;
                    arabic -= item.Key;
                }
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
