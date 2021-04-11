using Xunit;

namespace Algorithms.Tests
{
    public class CanCreateSumFromPositiveValuesTests
    {
        [Theory]
        [InlineData(new[] { 1, 5, 2, 2 }, 7, true)]
        [InlineData(new[] { 5, 2, 3 }, 6, false)]
        public void Test(int[] values, int sum, bool expected)
        {
            var actual = CanCreateSumFromPositiveValues.Check(values, sum);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1, 5, 2, 2 }, 7, true)]
        [InlineData(new[] { 5, 2, 3 }, 6, false)]
        public void Test2(int[] values, int sum, bool expected)
        {
            var actual = CanCreateSumFromPositiveValues.Check(values, sum);

            Assert.Equal(expected, actual);
        }
    }
}
