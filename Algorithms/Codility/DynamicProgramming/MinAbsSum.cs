using System;
using System.Linq;

namespace Codility.DynamicProgramming
{
    public class MinAbsSum
    {
        public int solution(int[] A)
        {
            var sequence = new int[A.Length];
            var max = 0;
            var sum = 0;

            for (var i = 0; i < A.Length; ++i)
            {
                sequence[i] = Math.Abs(A[i]);
                max = Math.Max(max, sequence[i]);
                sum += sequence[i];
            }

            var occurence = new int[max + 1];

            foreach (var el in sequence)
            {
                occurence[el] += 1;
            }

            var dp = Enumerable.Repeat(-1, sum + 1).ToArray();
            dp[0] = 0;

            for (var i = 1; i < occurence.Length; ++i)
            {
                if (occurence[i] == 0)
                {
                    continue;
                }

                for (var j = 0; j < dp.Length; ++j)
                {
                    if (dp[j] >= 0)
                    {
                        dp[j] = occurence[i];
                    }
                    else if (j >= i && dp[j - i] > 0)
                    {
                        dp[j] = dp[j - i] - 1;
                    }
                }
            }

            var result = int.MaxValue;

            for (var i = 0; i < sum / 2 + 1; ++i)
            {
                if (dp[i] >= 0)
                {
                    result = Math.Min(result, sum - 2 * i);
                }
            }

            return result;
        }
    }
}
