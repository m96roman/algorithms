using System.Linq;

namespace Algorithms
{
    public static class CanCreateSumFromPositiveValues
    {
        public static bool Check(int[] values, int sum)
        {
            var dp = new bool[sum + 1];
            dp[0] = true;

            foreach (var value in values)
            {
                for (var j = dp.Length - 1; j >= 0; --j)
                {
                    if (dp[j] && j + value < dp.Length)
                    {
                        dp[j + value] = true;
                    }
                }
            }

            return dp[sum];
        }

        public static bool Check2(int[] values, int sum)
        {
            var max = values.Max();
            var occurrence = new int[max + 1];

            foreach (var el in values)
            {
                occurrence[el] += 1;
            }

            var dp = Enumerable.Repeat(-1, sum + 1).ToArray();
            dp[0] = 0;

            for (var i = 1; i < occurrence.Length; ++i)
            {
                if (occurrence[i] == 0)
                {
                    continue;
                }

                for (var j = 0; j < dp.Length; ++j)
                {
                    if (dp[j] >= 0)
                    {
                        //values are not used as sum can already be created
                        dp[j] = occurrence[i];
                    }
                    else if (j >= i && dp[j - i] > 0)
                    {
                        //use one value, so decrease count of occurrences
                        dp[j] = dp[j - i] - 1;
                    }
                }
            }

            return dp[sum] >= 0;
        }
    }
}
