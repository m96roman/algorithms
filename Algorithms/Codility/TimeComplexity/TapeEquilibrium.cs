using System;
using System.Linq;

namespace Codility.TimeComplexity
{
    public class TapeEquilibrium
    {
        public int solution(int[] A)
        {
            var sumOfAllElements = A.Sum();
            var minDiff = int.MaxValue;

            var leftSum = A[0];
            var rightSum = sumOfAllElements - A[0];

            for (var i = 0; i < A.Length - 1; ++i)
            {
                var difference = Math.Abs(rightSum - leftSum);

                if (difference < minDiff)
                {
                    minDiff = difference;
                }

                leftSum += A[i + 1];
                rightSum -= A[i + 1];
            }

            return minDiff;
        }
    }
}
