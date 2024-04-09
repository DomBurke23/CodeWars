using ValidPhoneNumber;
using Xunit;

namespace UnitTests
{
    public class ValidPhoneNumberTests
    {
        [Fact]
        public void ValidPhoneNumberTest()
        {
            Assert.True(ValidPhoneNumberProgram.ValidPhoneNumberCheck("(123) 456-7890"));
            Assert.False(ValidPhoneNumberProgram.ValidPhoneNumberCheck("(1111)5X5 2345"));
        }
    }
}
