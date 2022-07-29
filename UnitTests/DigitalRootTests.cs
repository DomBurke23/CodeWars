using DigitalRoot;
using Xunit;

namespace UnitTests
{
    public class DigitalRootTests
    {
        [Theory]
        [InlineData(16, 7)]
        [InlineData(456, 6)]
        [InlineData(942, 6)]
        [InlineData(132189, 6)]
        [InlineData(493193, 2)]
        public static void DigitalRootTest(long numberToCheck, int expectedResult)
        {
            var actualResult = DigitalRootProgram.DigitalRoot(numberToCheck);
            Assert.Equal(expectedResult, actualResult);
        }
    }
}