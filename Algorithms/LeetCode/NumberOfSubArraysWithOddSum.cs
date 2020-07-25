namespace LeetCode
{
    public class NumberOfSubArraysWithOddSum
    {
        public int NumOfSubarrays(int[] arr)
        {
            const int mod = 1000000007;

            var countOfOddSum = 0;
            var lastCountOfOddSum = 0;

            for (var i = 0; i < arr.Length; ++i)
            {
                if (arr[i] % 2 == 1)
                {
                    // i - lastCountOfOddSum - count of even for previous step
                    // 1 - current element
                    lastCountOfOddSum = i - lastCountOfOddSum + 1;
                }

                countOfOddSum += lastCountOfOddSum;
                countOfOddSum %= mod;
            }

            return countOfOddSum;
        }
    }
}
