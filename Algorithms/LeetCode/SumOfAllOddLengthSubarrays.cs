namespace LeetCode
{
    public class SumOfAllOddLengthSubArrays
    {
        public int SumOddLengthSubArrays(int[] arr)
        {
            var prefixSum = new int[arr.Length];
            prefixSum[0] = arr[0];

            for (var i = 1; i < arr.Length; ++i)
            {
                prefixSum[i] = prefixSum[i - 1] + arr[i];
            }

            var total = 0;

            for (var i = 1; i <= arr.Length; i += 2)
            {
                for (var j = i - 1; j < arr.Length; ++j)
                {
                    total += prefixSum[j] - (j - i >= 0 ? prefixSum[j - i] : 0);
                }
            }

            return total;
        }
    }
}
