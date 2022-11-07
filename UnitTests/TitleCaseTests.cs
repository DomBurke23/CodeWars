using TitleCase;
using Xunit;

namespace UnitTests
{
    public class TitleCaseTests
    {
        [Theory]
        [InlineData("a clash of KINGS", "a an the of", "A Clash of Kings")]
        [InlineData("THE WIND IN THE WILLOWS", "The In", "The Wind in the Willows")]
        [InlineData("aBC deF Ghi", null, "Abc Def Ghi")]
        [InlineData("ab", "ab", "Ab")]
        [InlineData("a bc", "bc", "A bc")]
        [InlineData("a bc", "BC", "A bc")]
        [InlineData("First a of in", "an often into", "First A Of In")]
        [InlineData("the QUICK bRoWn fOX", "xyz fox quick the", "The quick Brown fox")]
        public static void TitleCaseTest(string title, string minorWords, string expected)
        {
            var actualResult = TitleCaseProgram.TitleCase(title,
                minorWords);
            Assert.Equal(expected, actualResult);
        }
    }
}
