﻿namespace LeetCode
{
    public class UniqueBinarySearchTrees
    {
        public int NumTrees(int n)
        {
            var dp = new int[n + 1];
            dp[0] = 1;

            for (var i = 1; i <= n; ++i)
            {
                for (var j = 0; j < i; ++j)
                {
                    dp[i] += dp[j] * dp[i - j - 1];
                }
            }

            return dp[n];
        }
    }
}
