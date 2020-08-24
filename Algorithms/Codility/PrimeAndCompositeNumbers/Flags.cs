using System;
using System.Collections.Generic;
using System.Linq;
using Algorithms;

namespace Codility.PrimeAndCompositeNumbers
{
    public class Flags
    {
        public int solution(int[] A)
        {
            var peaks = new List<int>();

            for (var i = 1; i + 1 < A.Length; ++i)
            {
                if (A[i] > A[i - 1] && A[i] > A[i + 1])
                {
                    peaks.Add(i);
                }
            }

            if (!peaks.Any())
            {
                return 0;
            }

            var lowerBound = 0;
            var upperBound = (int)Math.Ceiling(Math.Sqrt(A.Length));

            return BinarySearch.SearchMax(lowerBound, upperBound, (mid) =>
            {
                var lastPeakUsed = peaks.First();
                var peaksUsed = 1;

                foreach (var peak in peaks.Skip(1))
                {
                    if (peak - lastPeakUsed >= mid)
                    {
                        lastPeakUsed = peak;
                        ++peaksUsed;
                    }
                }

                return peaksUsed >= mid;
            });
        }
    }
}
