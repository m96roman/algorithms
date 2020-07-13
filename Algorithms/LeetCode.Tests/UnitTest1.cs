using System;
using Xunit;

namespace LeetCode.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(5, new[] { 1, 2, 5 }, 4)]
        [InlineData(3, new[] { 2 }, 0)]
        [InlineData(10, new[] { 10 }, 1)]
        [InlineData(8, new int[0], 0)]
        [InlineData(9, new[] { 3 }, 1)]
        public void CoinChange2_Change(int amount, int[] coins, int expected)
        {
            var algo = new CoinChange2();
            var actual = algo.Change(amount, coins);

            Assert.Equal(expected, actual);
        }
    }
}
