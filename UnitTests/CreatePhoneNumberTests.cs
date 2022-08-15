using CreatePhoneNumber;
using Xunit;

namespace UnitTests
{
    public class CreatePhoneNumberTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, "(123) 456-7890")]
        [InlineData(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, "(111) 111-1111")]
        public static void CreatePhoneNumberTest(int[] input, string expectedResult)
        {
            var actualResult = CreatePhoneNumberProgram.CreatePhoneNumber(input);
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
