using System;
using System.Linq;

namespace LeetCode
{
    public class CoinChange
    {
        public int Change(int[] coins, int amount)
        {
            var dp = Enumerable.Repeat(-1, amount + 1).ToArray();
            dp[0] = 0;

            foreach (var coin in coins)
            {
                for (var j = 1; j < dp.Length; ++j)
                {
                    if (j < coin || dp[j - coin] == -1)
                    {
                        continue;
                    }

                    dp[j] = dp[j] == -1
                        ? dp[j - coin] + 1
                        : Math.Min(dp[j], dp[j - coin] + 1);
                }
            }

            return dp[amount];
        }
    }
}
