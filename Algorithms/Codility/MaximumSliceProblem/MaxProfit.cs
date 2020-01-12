using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Algorithms;

namespace Codility.MaximumSliceProblem
{
    public class MaxProfit
    {
        public int solution(int[] A)
        {
            var minElement = int.MaxValue;
            var maxDiff = 0;

            foreach (var el in A)
            {
                minElement = Math.Min(el, minElement);
                maxDiff = Math.Max(el - minElement, maxDiff);
            }

            return maxDiff;
        }
    }
}
