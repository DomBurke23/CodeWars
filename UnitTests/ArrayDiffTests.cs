using ArrayDiff;
using Xunit;

namespace UnitTests
{
    public class ArrayDiffTests
    {
        [Theory]
        [InlineData(new int[] { 2 }, new int[] { 1, 2 }, new int[] { 1 })]
        [InlineData(new int[] { 2, 2 }, new int[] { 1, 2, 2 }, new int[] { 1 })]
        [InlineData(new int[] { 1 }, new int[] { 1, 2, 2 }, new int[] { 2 })]
        [InlineData(new int[] { 1, 2, 2 }, new int[] { 1, 2, 2 }, new int[] { })]
        [InlineData(new int[] { }, new int[] { }, new int[] { 1, 2 })]
        [InlineData(new int[] { 3 }, new int[] { 1, 2, 3 }, new int[] { 1, 2 })]
        public void ArrayDiffTest(int[] expected, int[] listA, int[] listB)
        {
            Assert.Equal(expected, ArrayDiffProgram.ArrayDiffs(listA, listB));
        }
    }
}
