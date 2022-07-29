using ASquareofSquares;
using Xunit;

namespace UnitTests
{
    public class ASquareOfSquaresTests
    {
        [Theory]
        [InlineData(-1, false)]
        [InlineData(0, true)]
        [InlineData(3, false)]
        [InlineData(4, true)]
        [InlineData(25, true)]
        [InlineData(26, false)]
        public static void ASquareOfSquaresTest(int numberToCheck, bool expectedResult)
        {
            var actualResult = ASquareofSquaresProgram.Square(numberToCheck);
            Assert.Equal(expectedResult, actualResult);
        }
    }
}