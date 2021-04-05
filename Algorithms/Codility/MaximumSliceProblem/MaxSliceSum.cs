using Algorithms;

namespace Codility.MaximumSliceProblem
{
    public class MaxSliceSum
    {
        public int solution(int[] A)
        {
            return KadanesAlgorithm.FindSubArrayMaxSum(A);
        }
    }
}
