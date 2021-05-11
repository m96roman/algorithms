using System;
using System.Linq;

namespace LeetCode
{
    public class MaximumPointsYouCanObtainFromCards
    {
        public int MaxScore(int[] cardPoints, int k)
        {
            var rightSum = cardPoints
                .Take(k)
                .Sum();

            var length = cardPoints.Length;
            var maxSum = rightSum;
            var sum = rightSum;

            for (var i = 0; i < k; ++i)
            {
                sum = sum - cardPoints[k - i - 1] + cardPoints[length - i - 1];
                maxSum = Math.Max(maxSum, sum);
            }

            return maxSum;
        }
    }
}
