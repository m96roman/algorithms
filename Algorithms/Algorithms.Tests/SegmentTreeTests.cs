using System;
using Xunit;

namespace Algorithms.Tests
{
    public class SegmentTreeTests
    {
        [Theory]
        [InlineData(new[] { 4, 5, 1, 2, 4, 5 }, 1, 4, 12)]
        public void CalculateOnRange_FindSum_ShouldReturnCorrectSum(int[] array, int start, int end, int expected)
        {
            //act
            var segmentTree = new SegmentTree<int>(array, (a, b) => a + b, 0);
            var sum = segmentTree.CalculateOnRange(start, end);

            //assert
            Assert.Equal(expected, sum);
        }

        [Theory]
        [InlineData(new[] { 4, 5, 8, 2, 4, 5 }, 1, 4, 2)]
        public void CalculateOnRange_FindMin_ShouldReturnCorrectMinValue(int[] array, int start, int end, int expected)
        {
            //act
            var segmentTree = new SegmentTree<int>(array, Math.Min, int.MaxValue);
            var min = segmentTree.CalculateOnRange(start, end);

            //assert
            Assert.Equal(expected, min);
        }

        [Theory]
        [InlineData(new[] { 4, 5, 8, 2, 4, 5 }, 1, 4, 8)]
        public void CalculateOnRange_FindMax_ShouldReturnCorrectMaxValue(int[] array, int start, int end, int expected)
        {
            //act
            var segmentTree = new SegmentTree<int>(array, Math.Max, int.MinValue);
            var min = segmentTree.CalculateOnRange(start, end);

            //assert
            Assert.Equal(expected, min);
        }
    }
}
