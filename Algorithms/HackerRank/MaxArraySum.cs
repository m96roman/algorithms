using System;
using System.Linq;

namespace HackerRank
{
    public class MaxArraySum
    {
        public int MaxSubsetSum(int[] arr)
        {
            if (arr.Length == 1)
            {
                return arr[0];
            }

            var dp = arr.ToArray();

            dp[1] = Math.Max(dp[0], dp[1]);

            for (var i = 2; i < dp.Length; ++i)
            {
                dp[i] = Math.Max(Math.Max(dp[i], dp[i - 2] + dp[i]), dp[i - 1]);
            }

            return dp.Max();
        }
    }
}
