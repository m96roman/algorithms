using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class TwoSum
    {
        public int[] Solve(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; ++i)
            {
                var complement = target - nums[i];

                if (map.ContainsKey(complement))
                {
                    return new[] { map[complement], i };
                }

                map[nums[i]] = i;
            }

            throw new ArgumentException("Input data has no solution");
        }
    }
}
