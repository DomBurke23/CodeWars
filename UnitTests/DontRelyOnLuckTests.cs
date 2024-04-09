using DontRelyOnLuck;
using Xunit;

namespace UnitTests
{
    public class DontRelyOnLuckTests
    {
        [Fact]
        public void DontRelyOnLuckTest()
        {
            var random = new Random().Next(1, 100 + 1);
            Assert.Equal(random, DontRelyOnLuckProgram.DontRelyOnLuck());
        }
    }
}