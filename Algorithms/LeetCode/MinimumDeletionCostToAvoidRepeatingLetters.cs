using System;

namespace LeetCode
{
    public class MinimumDeletionCostToAvoidRepeatingLetters
    {
        public int MinCost(string s, int[] cost)
        {
            var last = '-';
            var max = 0;
            var sum = 0;

            var minFullCost = 0;

            for (var i = 0; i < s.Length; ++i)
            {
                if (last == s[i])
                {
                    sum += cost[i];
                    max = Math.Max(cost[i], max);
                }
                else
                {
                    minFullCost += sum - max;

                    last = s[i];
                    sum = cost[i];
                    max = cost[i];
                }
            }

            minFullCost += sum - max;

            return minFullCost;
        }
    }
}
