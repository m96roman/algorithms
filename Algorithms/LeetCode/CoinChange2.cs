namespace LeetCode
{
    public class CoinChange2
    {
        public int Change(int amount, int[] coins)
        {
            var dp = new int[coins.Length + 1][];

            for (var i = 0; i < dp.Length; ++i)
            {
                dp[i] = new int[amount + 1];
                dp[i][0] = 1;
            }

            for (var i = 1; i < dp.Length; ++i)
            {
                for (var j = 1; j < dp[i].Length; ++j)
                {
                    dp[i][j] = dp[i - 1][j];

                    if (j >= coins[i - 1])
                    {
                        dp[i][j] += dp[i][j - coins[i - 1]];
                    }
                }
            }

            return dp[coins.Length][amount];
        }
    }
}
