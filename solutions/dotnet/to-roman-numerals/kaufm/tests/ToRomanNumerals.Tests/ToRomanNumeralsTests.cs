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
        public void ToRomanNumeralsTheory(int input, string expected)
        {
            input
                .ToRomanNumerals()
                .Should()
                .Be(expected);
        }
    }
}