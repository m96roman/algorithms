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

                    if (counters[el] < maxCounterToSet)
                    {
                        counters[el] = maxCounterToSet;
                    }

                    ++counters[el];

                    if (counters[el] > maxCounter)
                    {
                        maxCounter = counters[el];
                    }
                }
            }

            for (var i = 0; i < N; ++i)
            {
                if (counters[i] < maxCounterToSet)
                {
                    counters[i] = maxCounterToSet;
                }
            }

            return counters;
        }
    }
}
