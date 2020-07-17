using System.IO.Compression;
using Codility.DynamicProgramming;
using Codility.MaximumSliceProblem;
using Xunit;

namespace Codility.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new[] { 1, 5, 2, -2 }, 0)]
        public void MinAbsSum(int[] input, int expected)
        {
            var algo = new MinAbsSum();
            var actual = algo.solution(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 3, 2, 6, -1, 4, 5, -1, 2 }, 17)]
        [InlineData(new[] { 1, -4, 4, 8, 7 }, 12)]
        [InlineData(new[] { 4, 5, 3 }, 0)]
        [InlineData(new[] { -2, -4, -1, 1, -2 }, 1)]
        [InlineData(new[] { 5, 17, 0, 3 }, 17)]
        [InlineData(new[] { 5, 0, 17, 3 }, 17)]
        [InlineData(new[] { 6, 1, 5, 6, 4, 2, 9, 4 }, 26)]
        public void MaxDoubleSliceSum(int[] input, int expected)
        {
            var algo = new MaxDoubleSliceSum();
            var actual = algo.solution(input);

            Assert.Equal(expected, actual);
        }
    }
}
