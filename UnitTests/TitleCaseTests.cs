using TitleCase;
using Xunit;

namespace UnitTests
{
    public class TitleCaseTests
    {
        [Theory]
        [InlineData("a clash of KINGS", "a an the of", "A Clash of Kings")]
        [InlineData("THE WIND IN THE WILLOWS", "The In", "The Wind in the Willows")]
        public static void TitleCaseTest(string title, string minorWords, string expected)
        {
            var actualResult = TitleCaseProgram.TitleCase(title,
                minorWords);
            Assert.Equal(expected, actualResult);
        }
    }
}
