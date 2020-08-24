using Algorithms;

namespace Codility.BinarySearchAlgorithm
{
    public class NailingPlanks
    {
        public int solution(int[] A, int[] B, int[] C)
        {
            var planksCount = A.Length;
            var nailsCount = C.Length;

            var start = 1;
            var end = planksCount;

            return BinarySearch.SearchMin(start, end, (mid) =>
            {
                var prefixSum = new int[2 * nailsCount + 1];

                for (var i = 0; i < mid; ++i)
                {
                    prefixSum[C[i]] = 1;
                }

                for (var i = 1; i < prefixSum.Length; ++i)
                {
                    prefixSum[i] += prefixSum[i - 1];
                }

                var allPlanksAreNailed = true;

                for (var i = 0; i < planksCount; ++i)
                {
                    if (prefixSum[B[i]] == prefixSum[A[i] - 1])
                    {
                        allPlanksAreNailed = false;
                        break;
                    }
                }

                return allPlanksAreNailed;
            });
        }
    }
}
