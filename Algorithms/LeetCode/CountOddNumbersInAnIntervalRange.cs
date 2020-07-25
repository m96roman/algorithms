namespace LeetCode
{
    public class CountOddNumbersInAnIntervalRange
    {
        public int CountOdds(int low, int high)
        {
            return (high - low + 1) / 2 + (high & low & 1);
        }
    }
}
