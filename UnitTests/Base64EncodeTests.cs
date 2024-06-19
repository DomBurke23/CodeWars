using Base64Encode;
using Xunit;

namespace UnitTests
{
    public class Base64EncodeTests
    {
        [Theory]
        [InlineData("this is a string!!", "dGhpcyBpcyBhIHN0cmluZyEh")]
        [InlineData("ee", "ZWU=")]
        [InlineData("e", "ZQ==")]
        [InlineData("", "")]
        public static void Base64EncodeTest(string value, string expected)
        {
            var response = Base64EncodeProgram.Encode(value);
            Assert.True(expected == response, $"response returned - {response}");
        }

        [Theory]
        [InlineData("dGhpcyBpcyBhIHN0cmluZyEh", "this is a string!!")]
        [InlineData("ZWU=", "ee")]
        [InlineData("ZQ==", "e")]
        [InlineData("", "")]
        public static void Base64DecodeTest(string value, string expected)
        {
            var response = Base64EncodeProgram.Decode(value);
            Assert.True(expected == response, $"response returned - {response}");
        }
    }
}