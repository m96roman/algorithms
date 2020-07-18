using System;
using System.Collections.Generic;
using System.Linq;

namespace Codility.FibonacciNumbers
{
    public class FibFrog
    {
        public int solution(int[] A)
        {
            var sequence = A.Concat(new[] { 1 }).ToArray();

            var fib = new List<int> { 1, 2 };
            while (fib[fib.Count - 1] + fib[fib.Count - 2] <= sequence.Length)
            {
                fib.Add(fib[fib.Count - 1] + fib[fib.Count - 2]);
            }

            var dp = Enumerable.Repeat(-1, sequence.Length).ToArray();

            foreach (var fibNumber in fib)
            {
                if (fibNumber == sequence.Length)
                {
                    return 1;
                }

                if (sequence[fibNumber - 1] == 1)
                {
                    dp[fibNumber - 1] = 1;
                }
            }

            for (var i = 0; i < sequence.Length; ++i)
            {
                if (dp[i] == -1)
                {
                    continue;
                }

                foreach (var fibNumber in fib)
                {
                    if (i + fibNumber >= sequence.Length)
                    {
                        break;
                    }

                    if (sequence[i + fibNumber] == 0)
                    {
                        continue;
                    }

                    dp[i + fibNumber] = dp[i + fibNumber] == -1
                        ? dp[i] + 1
                        : Math.Min(dp[i] + 1, dp[i + fibNumber]);
                }
            }

            return dp[sequence.Length - 1];
        }
    }
}
