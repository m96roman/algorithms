using System;
using System.Linq;

namespace Codility.TimeComplexity
{
    public class TapeEquilibrium
    {
        public int solution(int[] A)
        {
            var minDiff = int.MaxValue;
            var sumOfAllElements = A.Sum();
            var sum = 0;

            for (var i = 1; i < A.Length; ++i)
            {
                sum += A[i - 1];

                var difference = Math.Abs(sumOfAllElements - 2 * sum);
                minDiff = Math.Min(minDiff, difference);
            }

            return minDiff;
        }
    }
}
