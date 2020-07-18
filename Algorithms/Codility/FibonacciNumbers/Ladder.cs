using System.Linq;

namespace Codility.FibonacciNumbers
{
    public class Ladder
    {
        public int[] solution(int[] A, int[] B)
        {
            var results = new int[A.Length];
            var groupedLadders = A.Zip(B, (a, b) => new { a, b })
                .Select((it, i) => new { idx = i, el = it.a, pow = it.b })
                .GroupBy(it => it.pow)
                .Select(it => new { pow = it.Key, ladders = it.OrderBy(l => l.el).ToArray() })
                .ToArray();

            foreach (var group in groupedLadders)
            {
                var dp = new int[2];
                dp[0] = 1;
                dp[1] = 1;

                var powOfTwo = (1 << group.pow) - 1;

                var nextLadder = 2;
                foreach (var ladder in group.ladders)
                {
                    for (var j = nextLadder; j <= ladder.el; ++j)
                    {
                        dp[j % 2] = (dp[0] + dp[1]) & powOfTwo;
                    }

                    nextLadder = ladder.el + 1;
                    results[ladder.idx] = dp[ladder.el % 2];
                }
            }

            return results;
        }
    }
}
