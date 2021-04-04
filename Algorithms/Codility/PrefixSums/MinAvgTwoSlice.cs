namespace Codility.PrefixSums
{
    public class MinAvgTwoSlice
    {
        public int solution(int[] A)
        {
            var minAvg = 10001.0;
            var minAvgStartIndex = 0;

            for (var i = 0; i < A.Length - 1; ++i)
            {
                var twoAvg = (A[i] + A[i + 1]) / 2.0;

                if (twoAvg < minAvg)
                {
                    minAvg = twoAvg;
                    minAvgStartIndex = i;
                }

                if (i + 2 == A.Length)
                {
                    continue;
                }

                var threeAvg = (A[i] + A[i + 1] + A[i + 2]) / 3.0;

                if (threeAvg < minAvg)
                {
                    minAvg = threeAvg;
                    minAvgStartIndex = i;
                }
            }

            return minAvgStartIndex;
        }
    }
}
