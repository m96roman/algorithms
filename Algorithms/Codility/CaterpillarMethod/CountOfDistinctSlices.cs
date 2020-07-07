using System.Collections;
using System.Linq;

namespace Codility.CaterpillarMethod
{
    public class CountOfDistinctSlices
    {
        public int solution(int M, int[] A)
        {
            const int maxSlicesCount = 1000000000;

            var sequence = A;

            var slicesCount = 0;
            var presence = new BitArray(M + 1);
            var lastSliceStart = 0;

            for (var i = 0; i < sequence.Length; ++i)
            {
                var el = sequence[i];

                if (presence[el])
                {
                    var j = lastSliceStart;

                    while (sequence[j] != el)
                    {
                        presence[sequence[j]] = false;
                        ++j;
                    }

                    lastSliceStart = j + 1;
                }
                else
                {
                    presence[el] = true;
                }

                slicesCount += i - lastSliceStart + 1;

                if (slicesCount >= maxSlicesCount)
                {
                    return maxSlicesCount;
                }
            }

            return slicesCount;
        }
    }
}