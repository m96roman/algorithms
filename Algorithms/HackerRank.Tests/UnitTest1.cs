using Xunit;

namespace HackerRank.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new[] { -2, 1, 3, -4, 5 }, 8)]
        [InlineData(new[] { 3, 7, 4, 6, 5 }, 13)]
        [InlineData(new[] { 2, 1, 5, 8, 4 }, 11)]
        [InlineData(new[] { 3, 5, -7, 8, 10 }, 15)]
        [InlineData(new[] { 12 }, 12)]
        public void MaxArraySum_MaxSubsetSum(int[] arr, int expected)
        {
            var algo = new MaxArraySum();
            var actual = algo.MaxSubsetSum(arr);

            Assert.Equal(expected, actual);
        }
    }
}
