namespace LeetCode
{
    public class JumpGame
    {
        public bool CanJump(int[] nums)
        {
            var positionFrom = 0;

            for (var i = 1; i < nums.Length; ++i)
            {
                while (positionFrom + nums[positionFrom] < i)
                {
                    ++positionFrom;
                }

                if (positionFrom == i)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
