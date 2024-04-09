using PascalsTriangle;
using System.Collections.Generic;
using Xunit;

namespace UnitTests
{
    public class PascalsTriangleTests
    {
        [Fact]
        public void Level1()
        {
            Assert.Equal( new List<int> { 1 },
                PascalsTriangleProgram.PascalsTriangle(1));
        }

        [Fact]
        public void Level2()
        {
            Assert.Equal(
              new List<int> { 1, 1, 1 },
              PascalsTriangleProgram.PascalsTriangle(2));
        }

        [Fact]
        public void Level4()
        {
            Assert.Equal(
              new List<int> { 1, 1, 1, 1, 2, 1, 1, 3, 3, 1 },
              PascalsTriangleProgram.PascalsTriangle(4));
        }
    }
}