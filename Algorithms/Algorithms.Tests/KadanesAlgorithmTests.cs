using Xunit;

namespace Algorithms.Tests
{
    public class KadanesAlgorithmTests
    {
        [Theory]
        [InlineData(new[]{-2, -3, 4, -1, -2, 1, 5, -3}, 7)]
        public void FindSubArrayMaxSum_ReturnsCorrectSum(int[] array, int expected)
        {
            var actual = KadanesAlgorithm.FindSubArrayMaxSum(array);

            Assert.Equal(expected, actual);
        }
    }
}
