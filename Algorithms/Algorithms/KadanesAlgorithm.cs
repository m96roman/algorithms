using System;
using System.Linq;

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

        public static int[] FindSubArrayMaxSumEndingAt(int[] array)
        {
            var maxSumEndingAt = new int[array.Length];
            maxSumEndingAt[0] = array[0];

            for (var i = 1; i < array.Length; ++i)
            {
                maxSumEndingAt[i] = Math.Max(array[i], maxSumEndingAt[i - 1] + array[i]);
            }

            return maxSumEndingAt;
        }

        public static int[] FindSubArrayMaxSumStartingAt(int[] array)
        {
            var reverseArray = array.Reverse().ToArray();

            var maxSumEndingAt = new int[reverseArray.Length];
            maxSumEndingAt[0] = reverseArray[0];

            for (var i = 1; i < reverseArray.Length; ++i)
            {
                maxSumEndingAt[i] = Math.Max(reverseArray[i], maxSumEndingAt[i - 1] + reverseArray[i]);
            }

            var maxSumStartingAt = maxSumEndingAt.Reverse().ToArray();

            return maxSumStartingAt;
        }
    }
}
