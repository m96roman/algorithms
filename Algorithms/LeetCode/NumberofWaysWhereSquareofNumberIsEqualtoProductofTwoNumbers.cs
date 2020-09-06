using System.Collections.Generic;

namespace LeetCode
{
    public class NumberOfWaysWhereSquareOfNumberIsEqualtoProductOfTwoNumbers
    {
        public int NumTriplets(int[] nums1, int[] nums2) =>
            CalculateTriples(nums1, CreateCache(nums2)) + CalculateTriples(nums2, CreateCache(nums1));

        private static int CalculateTriples(int[] nums, Dictionary<long, int> cache)
        {
            var count = 0;

            for (var i = 0; i < nums.Length; ++i)
            {
                for (var j = i + 1; j < nums.Length; ++j)
                {
                    var product = (long)nums[i] * nums[j];

                    if (cache.ContainsKey(product))
                    {
                        count += cache[product];
                    }
                }
            }

            return count;
        }

        private static Dictionary<long, int> CreateCache(int[] nums)
        {
            var cache = new Dictionary<long, int>();

            foreach (var el in nums)
            {
                var product = (long)el * el;

                if (cache.ContainsKey(product))
                {
                    cache[product]++;
                }
                else
                {
                    cache.Add(product, 1);
                }
            }

            return cache;
        }
    }
}
