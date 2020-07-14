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

            for (var i = 0; i < A.Length - 1; ++i)
            {
                sum += A[i];
                var difference = Math.Abs(sumOfAllElements - 2 * sum);

                if (difference < minDiff)
                {
                    minDiff = difference;
                }
            }

            return minDiff;
        }
    }
}
