using System;
using Xunit;
using ToRomanNumerals;
using FluentAssertions;

namespace ToRomanNumerals.Tests
{
    public class ToRomanNumeralsTests
    {
        [Theory]
        [InlineData(0, "")]
        [InlineData(-1, "")]
        [InlineData(int.MinValue, "")]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(8, "VIII")]
        public void ToRomanNumeralsTheory(int input, string expected)
        {
            input
                .ToRomanNumerals()
                .Should()
                .Be(expected);
        }
    }
}
