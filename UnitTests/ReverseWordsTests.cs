using ReverseWords;
using Xunit;

namespace UnitTests
{
    public class ReverseWordsTests
    {
        [Theory]
        [InlineData("This is an example!", "sihT si na !elpmaxe")]
        [InlineData("double  spaces", "elbuod  secaps")]
        [InlineData("The quick brown fox jumps over the lazy dog.", "ehT kciuq nworb xof spmuj revo eht yzal .god")]
        public static void ReverseWordsTest(string input, string expectedResult)
        {
            var actualResult = ReverseWordsProgram.ReverseWords(input);
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
