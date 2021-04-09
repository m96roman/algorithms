using System.Linq;
using Algorithms;

namespace Codility.BinarySearchAlgorithm
{
    public class NailingPlanks
    {
        public int solution(int[] A, int[] B, int[] C)
        {
            var nailsCount = C.Length;
            var planks = A.Zip(B, (a, b) => new {start = a, end = b})
                .ToArray();

            return BinarySearch.SearchMin(0, nailsCount, (mid) =>
            {
                var prefixSum = new int[2 * nailsCount + 1];

                foreach (var nail in C.Take(mid))
                {
                    prefixSum[nail] = 1;
                }

                for (var i = 1; i < prefixSum.Length; ++i)
                {
                    prefixSum[i] += prefixSum[i - 1];
                }

                return planks
                    .Select(it => prefixSum[it.end] - prefixSum[it.start - 1])
                    .All(n => n >= 1);
            });
        }
    }
}
