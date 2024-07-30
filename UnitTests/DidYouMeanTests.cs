using DidYouMean;
using System.Collections.Generic;
using Xunit;

namespace UnitTests
{
    public class DidYouMeanTests
    {
        [Fact]
        public void TestDictionary1()
        {
            DidYouMeanProgram didYouMean = new DidYouMeanProgram(new List<string> { "cherry", "pineapple", "melon", "strawberry", "raspberry" });
            Assert.Equal("strawberry", DidYouMeanProgram.FindMostSimilar(didYouMean, "strawbery"));
            Assert.Equal("cherry", DidYouMeanProgram.FindMostSimilar(didYouMean, "berry"));
        }

        [Fact]
        public void TestDictionary2()
        {
            DidYouMeanProgram didYouMean = new DidYouMeanProgram(new List<string> { "javascript", "java", "ruby", "php", "python", "coffeescript" });
            Assert.Equal("java", DidYouMeanProgram.FindMostSimilar(didYouMean, "heaven"));
            Assert.Equal("javascript", DidYouMeanProgram.FindMostSimilar(didYouMean, "javascript"));
        }

        [Fact]
        public void TestDictionary3()
        {
            DidYouMeanProgram didYouMean = new DidYouMeanProgram(new List<string> { "stars", "mars", "wars", "codec", "codewars" });
            Assert.Equal("codewars", DidYouMeanProgram.FindMostSimilar(didYouMean, "coddwars"));
        }

        [Fact]
        public void TestDictionary4()
        {
            DidYouMeanProgram didYouMean = new DidYouMeanProgram(new List<string> { "beer", "beekeeper", "beehive", "beeswax", "honey" });
            Assert.Equal("beer", DidYouMeanProgram.FindMostSimilar(didYouMean, "beer"));
            Assert.Equal("beer", DidYouMeanProgram.FindMostSimilar(didYouMean, "ber"));
            Assert.Equal("beer", DidYouMeanProgram.FindMostSimilar(didYouMean, "bear"));
            Assert.Equal("beehive", DidYouMeanProgram.FindMostSimilar(didYouMean, "beehave"));
        }
    }
}
