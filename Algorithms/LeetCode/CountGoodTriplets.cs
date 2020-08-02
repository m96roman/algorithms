using System;

namespace LeetCode
{
    public class CountGoodTriplets
    {
        public int Solve(int[] arr, int a, int b, int c)
        {
            var count = 0;

            for (var i = 0; i <= arr.Length - 3; ++i)
            {
                for (var j = i + 1; j <= arr.Length - 2; ++j)
                {
                    if (Math.Abs(arr[j] - arr[i]) > a)
                    {
                        continue;
                    }

                    for (var k = j + 1; k <= arr.Length - 1; ++k)
                    {
                        if (Math.Abs(arr[k] - arr[j]) <= b && Math.Abs(arr[k] - arr[i]) <= c)
                        {
                            ++count;
                        }
                    }
                }
            }

            return count;
        }
    }
}
