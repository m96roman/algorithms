namespace Codility.GreedyAlgorithms
{
    public class MaxNonoverlappingSegments
    {
        public int solution(int[] A, int[] B)
        {
            var countOfNonOverlaping = 0;
            var lastEnding = -1;

            for (var i = 0; i < A.Length; ++i)
            {
                if (A[i] > lastEnding)
                {
                    lastEnding = B[i];
                    ++countOfNonOverlaping;
                }
            }

            return countOfNonOverlaping;
        }
    }
}
