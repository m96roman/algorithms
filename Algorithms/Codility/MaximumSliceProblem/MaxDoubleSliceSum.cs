using System;

namespace Codility.MaximumSliceProblem
{
    public class MaxDoubleSliceSum
    {
        public int solution(int[] A)
        {
            var maxSumStartingAt = new int[A.Length];
            var maxSumEndingAt = new int[A.Length];

            for (var i = 1; i < A.Length - 1; ++i)
            {
                maxSumEndingAt[i] = Math.Max(maxSumEndingAt[i - 1] + A[i], 0);
            }

            for (var i = A.Length - 2; i > 0; --i)
            {
                maxSumStartingAt[i] = Math.Max(maxSumStartingAt[i + 1] + A[i], 0);
            }

            var maxDoubleSlice = 0;

            for (var i = 1; i < A.Length - 1; ++i)
            {
                maxDoubleSlice = Math.Max(maxDoubleSlice, maxSumEndingAt[i - 1] + maxSumStartingAt[i + 1]);
            }

            return maxDoubleSlice;
        }
    }
}
