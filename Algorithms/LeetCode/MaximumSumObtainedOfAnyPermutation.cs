using System;
using System.Linq;

namespace LeetCode
{
    public class MaximumSumObtainedOfAnyPermutation
    {
        public int MaxSumRangeQuery(int[] nums, int[][] requests)
        {
            var beginning = new int[nums.Length];
            var ending = new int[nums.Length];

            foreach (var request in requests)
            {
                ++beginning[request[0]];
                ++ending[request[1]];
            }

            var frequencies = new int[nums.Length];

            var openedSegment = 0;

            for (var i = 0; i < nums.Length; ++i)
            {
                frequencies[i] = beginning[i] + openedSegment;
                openedSegment += beginning[i] - ending[i];
            }

            var mod = (int)Math.Pow(10, 9) + 7;

            var orderedNums = nums.OrderByDescending(it => it).ToArray();
            var orderedFrequencies = frequencies.OrderByDescending(it => it).ToArray();

            return orderedFrequencies
                .Zip(orderedNums, (f, n) => f * n)
                .Aggregate(0, (sum, el) => (sum + el) % mod);
        }
    }
}
