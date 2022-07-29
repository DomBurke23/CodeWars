using Multiply;
using Xunit;

namespace UnitTests
{
    public class MultiplyTests
    {
        [Theory]
        [InlineData(2, 1, 2)]
        [InlineData(2, 4, 8)]
        public static void MultiplyTest(int number1, int number2, int expectedResult)
        {
            var actualResult = MultiplyProgram.Multiply(number1, number2);
            Assert.Equal(expectedResult, actualResult);
        }
    }
}