using System.Linq;

namespace LeetCode
{
    public class NumberOfGoodLeafNodesPairs
    {
        public int CountPairs(TreeNode root, int distance)
        {
            if (distance == 1)
            {
                return 0;
            }

            var goodPairs = 0;
            GetLeafsDepth(root, distance, ref goodPairs);

            return goodPairs;
        }

        private int[] GetLeafsDepth(TreeNode root, int distance, ref int goodPairs)
        {
            if (root == null)
            {
                return new int[0];
            }

            if (root.left == null && root.right == null)
            {
                return new[] { 1 };
            }

            var leftLeafsDepths = GetLeafsDepth(root.left, distance, ref goodPairs);
            var rightLeafsDepths = GetLeafsDepth(root.right, distance, ref goodPairs);

            foreach (var leftDepth in leftLeafsDepths)
            {
                foreach (var rightDepth in rightLeafsDepths)
                {
                    if (leftDepth + rightDepth <= distance)
                    {
                        ++goodPairs;
                    }
                }
            }

            return leftLeafsDepths.Concat(rightLeafsDepths)
                .Select(it => it + 1)
                .ToArray();
        }
    }
}
