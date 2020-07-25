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

        [Theory]
        [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
        [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
        [InlineData(new[] { 3, 3 }, 6, new[] { 0, 1 })]
        public void TwoSum_Solve(int[] nums, int target, int[] expected)
        {
            var algo = new TwoSum();
            var actual = algo.Solve(nums, target);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(12, 30, 165)]
        [InlineData(3, 30, 75)]
        [InlineData(3, 15, 7.5)]
        [InlineData(4, 50, 155)]
        [InlineData(24, 0, 0)]
        public void AngleBetweenHandsOfaClock_AngleClock(int hour, int minutes, double expected)
        {
            var algo = new AngleBetweenHandsOfaClock();
            var actual = algo.AngleClock(hour, minutes);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("the sky is blue", "blue is sky the")]
        [InlineData("  hello world!  ", "world! hello")]
        [InlineData("a good   example", "example good a")]
        public void ReverseWordsInAString_ReverseWords(string s, string expected)
        {
            var algo = new ReverseWordsInAString();
            var actual = algo.ReverseWords(s);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 2)]
        [InlineData(8, 3)]
        [InlineData(1, 1)]
        [InlineData(3, 2)]
        [InlineData(1804289383, 60070)]
        public void ArrangingCoins_ArrangeCoins(int n, int expected)
        {
            var algo = new ArrangingCoins();
            var actual = algo.ArrangeCoins(n);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 5 }, 11, 3)]
        [InlineData(new[] { 2, 5, 10, 1 }, 27, 4)]
        [InlineData(new[] { 1, 2, 3, 4 }, 6, 2)]
        [InlineData(new[] { 2 }, 3, -1)]
        [InlineData(new[] { 186, 419, 83, 408 }, 6249, 20)]
        public void CoinChange_Change(int[] coins, int amount, int expected)
        {
            var algo = new CoinChange();
            var actual = algo.Change(coins, amount);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 5)]
        [InlineData(4, 14)]
        public void UniqueBinarySearchTrees_NumTrees(int n, int expected)
        {
            var algo = new UniqueBinarySearchTrees();
            var actual = algo.NumTrees(n);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(15, 4, 19)]
        [InlineData(9, 3, 13)]
        public void WaterBottles_NumWaterBottles(int numBottles, int numExchange, int expected)
        {
            var algo = new WaterBottles();
            var actual = algo.NumWaterBottles(numBottles, numExchange);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1, 3, 5 }, 4)]
        [InlineData(new[] { 2, 4, 6 }, 0)]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7 }, 16)]
        [InlineData(new[] { 10, 100, 99, 99 }, 4)]
        [InlineData(new[] { 7 }, 1)]
        [InlineData(new[] { 1, 2 }, 2)]
        [InlineData(new[] { 1, 2, 3 }, 4)]
        [InlineData(new[] { 2, 5, 7 }, 3)]
        public void NumberOfSubArraysWithOddSum_NumOfSubarrays(int[] arr, int expected)
        {
            var algo = new NumberOfSubArraysWithOddSum();
            var actual = algo.NumOfSubarrays(arr);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 7, 3)]
        [InlineData(8, 10, 1)]
        public void CountOddNumbersInAnIntervalRange_CountOdds(int low, int high, int expected)
        {
            var algo = new CountOddNumbersInAnIntervalRange();
            var actual = algo.CountOdds(low, high);

            Assert.Equal(expected, actual);
        }
    }
}