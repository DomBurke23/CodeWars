using TenPinBowling;
using Xunit;

namespace UnitTests;

public class TenPinBowlingTests
{
    [Theory]
    [InlineData("11 11 11 11 11 11 11 11 11 11", 20)]
    [InlineData("X X X X X X X X X XXX", 300)]
    [InlineData("5/ 4/ 3/ 2/ 1/ 0/ X 9/ 4/ 8/8", 150)]
    public static void TenPinBowlingTest(string input, int expected)
    {
        var expectedScore = TenPinBowlingProgram.BowlingScore(input);;
        Assert.Equal(expectedScore, expected);
    }
}