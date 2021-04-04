using System;

namespace Algorithms
{
    public static class KadanesAlgorithm
    {
        public static int FindSubArrayMaxSum(int[] array)
        {
            var maxSum = int.MinValue;
            var currentSum = 0;

            foreach (var el in array)
            {
                currentSum = Math.Max(el, currentSum + el);
                maxSum = Math.Max(maxSum, currentSum);
            }

            return maxSum;
        }
    }
}
