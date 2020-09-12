using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Permutations
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            var result = new List<IList<int>>();

            PermutateInternal();

            return result;

            void PermutateInternal(int index = 0)
            {
                if (index == nums.Length - 1)
                {
                    result.Add(nums.ToArray());
                }

                for (var i = index; i < nums.Length; ++i)
                {
                    Swap(index, i);
                    PermutateInternal(index + 1);
                    Swap(index, i);
                }
            }

            void Swap(int l, int r)
            {
                var temp = nums[l];
                nums[l] = nums[r];
                nums[r] = temp;
            }
        }
    }
}
