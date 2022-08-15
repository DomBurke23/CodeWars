using ReverseWords;
using Xunit;

namespace UnitTests
{
    public class ReverseWordsTests
    {
        [Theory]
        [InlineData("This is an example!", "sihT si na !elpmaxe")]
        [InlineData("double  spaces", "elbuod  secaps")]
        public static void ReverseWordsTest(string input, string expectedResult)
        {
            var actualResult = ReverseWordsProgram.ReverseWords(input);
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
