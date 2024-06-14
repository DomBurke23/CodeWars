using RomanNumerals;
using Xunit;

namespace UnitTests
{
    public class RomanNumeralsTests
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(10, "X")]
        [InlineData(7, "VII")]

        public static void RomanNumeralsTest(int input, string expectedOutput)
        {
            var response = RomanNumeralsProgram.RomanNumeralsConversion(input);
            Assert.True(response == expectedOutput, $"Response returned - {response}");
        }
    }
}
