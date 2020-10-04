namespace LeetCode
{
    public class SpecialArrayWithXElementsGreaterThanOrEqualX
    {
        public int SpecialArray(int[] nums)
        {
            var map = new int[101];

            foreach (var num in nums)
            {
                var idx = num > 100 ? 100 : num;
                ++map[idx];
            }

            for (var i = 100; i >= 1; --i)
            {
                map[i - 1] += map[i];
            }

            for (var i = 1; i < map.Length; ++i)
            {
                if (map[i] == i)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
