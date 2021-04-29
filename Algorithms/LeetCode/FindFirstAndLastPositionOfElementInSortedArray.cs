using Algorithms;

namespace LeetCode
{
    public class FindFirstAndLastPositionOfElementInSortedArray
    {
        public int[] SearchRange(int[] nums, int target)
        {
            var result = BinarySearch.Search(0, nums.Length - 1, (mid, _) => new BinarySearch.StepResult
            {
                NextAction = nums[mid] == target
                    ? BinarySearch.Action.Stop
                    : nums[mid] > target
                        ? BinarySearch.Action.MoveLeft
                        : BinarySearch.Action.MoveRight,
                Success = nums[mid] == target
            });

            if (result == -1)
            {
                return new[] { -1, -1 };
            }

            var right = result;
            var left = result;

            while (right + 1 < nums.Length && nums[right + 1] == target)
            {
                ++right;
            }

            while (left - 1 >= 0 && nums[left - 1] == target)
            {
                --left;
            }

            return new[] { left, right };
        }
    }
}
