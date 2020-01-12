using System;
using System.Linq;

namespace Codility.MaximumSliceProblem
{
    public class MaxSliceSum
    {
        public int solution(int[] A)
        {
            var maxSlice = A[0];
            var maxSum = A[0];

            foreach (var el in A.Skip(1))
            {
                maxSum = Math.Max(el, el + maxSum);
                maxSlice = Math.Max(maxSlice, maxSum);
            }

            return maxSlice;
        }
    }
}
