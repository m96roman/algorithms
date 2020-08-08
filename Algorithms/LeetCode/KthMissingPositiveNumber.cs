namespace LeetCode
{
    public class KthMissingPositiveNumber
    {
        public int FindKthPositive(int[] arr, int k)
        {
            var countOfMissing = 0;
            var iterator = 0;

            foreach (var el in arr)
            {
                ++iterator;

                if (el == iterator)
                {
                    continue;
                }

                countOfMissing += el - iterator;

                if (countOfMissing >= k)
                {
                    return el - (countOfMissing - k) - 1;
                }

                iterator = el;
            }

            return iterator + (k - countOfMissing);
        }
    }
}