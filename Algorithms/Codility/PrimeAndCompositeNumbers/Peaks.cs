using System.Collections;
using System.Linq;

namespace Codility.PrimeAndCompositeNumbers
{
    public class Peaks
    {
        public int solution(int[] A)
        {
            var blocksMaxCount = 0;

            var peaks = new BitArray(A.Length);

            for (var i = 1; i + 1 < A.Length; ++i)
            {
                peaks[i] = A[i] > A[i - 1] && A[i] > A[i + 1];
            }

            var peaksPrefixSum = new int[A.Length];

            for (var i = 1; i < peaks.Length; ++i)
            {
                peaksPrefixSum[i] = peaksPrefixSum[i - 1] + (peaks[i] ? 1 : 0);
            }

            var prefixSum = peaksPrefixSum.Prepend(0).ToArray();

            if (prefixSum.Last() == 0)
            {
                return 0;
            }

            for (var i = 1; i <= A.Length; ++i)
            {
                if (A.Length % i != 0)
                {
                    continue;
                }

                var blockLength = A.Length / i;
                var possibleToUse = true;

                for (var j = blockLength; j < prefixSum.Length; j += blockLength)
                {
                    if (prefixSum[j] - prefixSum[j - blockLength] == 0)
                    {
                        possibleToUse = false;
                        break;
                    }
                }

                blocksMaxCount = possibleToUse ? i : blocksMaxCount;
            }

            return blocksMaxCount;
        }
    }
}
