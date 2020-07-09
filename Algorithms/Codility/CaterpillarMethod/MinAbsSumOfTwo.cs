using System;
using System.Linq;

namespace Codility.CaterpillarMethod
{
    public class MinAbsSumOfTwo
    {
        public int solution(int[] A)
        {
            var orderedSequence = A
                .OrderBy(it => it)
                .ToArray();

            var minAbsSum = int.MaxValue;

            var left = 0;
            var right = orderedSequence.Length - 1;

            while (left <= right)
            {
                var absSum = Math.Abs(orderedSequence[left] + orderedSequence[right]);
                minAbsSum = Math.Min(minAbsSum, absSum);

                if (Math.Abs(orderedSequence[left]) > Math.Abs(orderedSequence[right]))
                {
                    ++left;
                }
                else
                {
                    --right;
                }
            }

            return minAbsSum;
        }
    }
}
