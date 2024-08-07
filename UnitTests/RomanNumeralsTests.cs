﻿using RomanNumerals;
using System;
using Xunit;

namespace UnitTests
{
    public class RomanNumeralsTests
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(1000, "M")]
        [InlineData(1666, "MDCLXVI")]
        [InlineData(2022, "MMXXII")]
        [InlineData(1990, "MCMXC")]
        [InlineData(2008, "MMVIII")]
        [InlineData(3999, "MMMCMXCIX")]
        public static void RomanNumeralsTest(int input, string expectedOutput)
        {
            var response = RomanNumeralsProgram.ConvertToRomanNumerals(input);
            Assert.True(response == expectedOutput, $"Response returned - {response}");
        }

        [Theory]
        [InlineData(0, "Input must be between 1 and 3999 (Parameter '0')")]
        [InlineData(4000, "Input must be between 1 and 3999 (Parameter '4000')")]
        public static void RomanNumeralsExceptionTest(int input, string expectedOutput)
        {
            var response = Assert.Throws<ArgumentOutOfRangeException>(() => (RomanNumeralsProgram.ConvertToRomanNumerals(input)));
            Assert.True(response.Message == expectedOutput, $"Response returned {response.Message}");
        }

        [Theory]
        [InlineData("I", 1)]
        [InlineData("M", 1000)]
        [InlineData("MDCLXVI", 1666)]
        [InlineData("MMXXII", 2022)]
        [InlineData("MCMXC", 1990)]
        [InlineData("MMVIII", 2008)]
        [InlineData("MMMCMXCIX", 3999)]
        public static void ConvertFromRomanNumeralsTest(string input, int expectedOutput)
        {
            var response = RomanNumeralsProgram.ConvertFromRomanNumerals(input);
            Assert.True(response == expectedOutput, $"Response returned - {response}");
        }

    }
}
