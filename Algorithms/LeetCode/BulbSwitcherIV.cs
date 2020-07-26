namespace LeetCode
{
    public class BulbSwitcherIV
    {
        public int MinFlips(string target)
        {
            var countOfFlips = 0;
            var lastBulb = '0';

            foreach (var bulb in target)
            {
                if (bulb != lastBulb)
                {
                    ++countOfFlips;
                    lastBulb = bulb;
                }
            }

            return countOfFlips;
        }
    }
}
