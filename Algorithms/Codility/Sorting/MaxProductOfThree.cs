using System;
using System.Linq;

namespace Codility.Sorting
{
    public class MaxProductOfThree
    {
        public int solution(int[] A)
        {
            var length = A.Length;
            var sorted = A.OrderBy(it => it).ToArray();

            var productOfAllPositive = sorted[length - 1] * sorted[length - 2] * sorted[length - 3];
            var productOfPositiveAndTwoNegative = sorted[length - 1] * sorted[0] * sorted[1];

            return Math.Max(productOfAllPositive, productOfPositiveAndTwoNegative);
        }
    }
}
