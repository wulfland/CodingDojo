using System;
using System.Collections.Generic;
using System.Linq;

namespace ToRomanNumerals
{
    public static class Extensions
    {
        public static string FieldWithCodeSmell = "I will raise a smell in sonar";

        static IDictionary<int, string> constants = new Dictionary<int, string>
        {
            {  1, "I" },
            {  4, "IV" },
            {  5, "V" },
            {  9, "IX" },
            { 10, "X" },
            { 40, "XL" },
            { 50, "L" }
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
                   break; 
                }
            }

            result += ToRomanNumerals(arabic);

            return result;
        }
    }
}
