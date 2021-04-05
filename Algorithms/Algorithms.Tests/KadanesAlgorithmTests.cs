using Xunit;

namespace Algorithms.Tests
{
    public class KadanesAlgorithmTests
    {
        [Theory]
        [InlineData(new[] { -2, -3, 4, -1, -2, 1, 5, -3 }, 7)]
        public void FindSubArrayMaxSum_ReturnsCorrectSum(int[] array, int expected)
        {
            var actual = KadanesAlgorithm.FindSubArrayMaxSum(array);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { -2, -3, 4, -1, -2, 1, 5, -3 }, new[] { -2, -3, 4, 3, 1, 2, 7, 4 })]
        public void FindSubArrayMaxSumEndingAt_ReturnsCorrectArray(int[] array, int[] expected)
        {
            var actual = KadanesAlgorithm.FindSubArrayMaxSumEndingAt(array);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { -2, -3, 4, -1, -2, 1, 5, -3 }, new[] { 2, 4, 7, 3, 4, 6, 5, -3 })]
        public void FindSubArrayMaxSumStartingAt_ReturnsCorrectArray(int[] array, int[] expected)
        {
            var actual = KadanesAlgorithm.FindSubArrayMaxSumStartingAt(array);

            Assert.Equal(expected, actual);
        }
    }
}
