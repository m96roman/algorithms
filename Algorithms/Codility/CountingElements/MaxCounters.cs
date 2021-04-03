using System;

namespace Codility.CountingElements
{
    public class MaxCounters
    {
        public int[] solution(int N, int[] A)
        {
            var counters = new int[N];
            var maxCounter = 0;
            var maxCounterToSet = 0;

            foreach (var i in A)
            {
                if (i == N + 1)
                {
                    maxCounterToSet = maxCounter;
                }
                else
                {
                    var el = i - 1;

                    counters[el] = Math.Max(maxCounterToSet, counters[el]) + 1;
                    maxCounter = Math.Max(maxCounter, counters[el]);
                }
            }

            for (var i = 0; i < N; ++i)
            {
                counters[i] = Math.Max(counters[i], maxCounterToSet);
            }

            return counters;
        }
    }
}
