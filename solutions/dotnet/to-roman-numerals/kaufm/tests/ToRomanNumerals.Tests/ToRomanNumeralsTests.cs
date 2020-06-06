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
        public void ToRomanNumeralsTheory(int input, string expected)
        {
            input
                .ToRomanNumerals()
                .Should()
                .Be(expected);
        }
    }
}
