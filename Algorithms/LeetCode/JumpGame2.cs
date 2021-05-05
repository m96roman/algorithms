using System.Linq;

namespace LeetCode
{
    public class JumpGame2
    {
        public int Jump(int[] nums)
        {
            var jumpsNeeded = new int[nums.Length];
            var positionFrom = 0;

            for (var i = 1; i < jumpsNeeded.Length; ++i)
            {
                while (positionFrom + nums[positionFrom] < i)
                {
                    ++positionFrom;
                }

                jumpsNeeded[i] = jumpsNeeded[positionFrom] + 1;
            }

            return jumpsNeeded.Last();
        }
    }
}
