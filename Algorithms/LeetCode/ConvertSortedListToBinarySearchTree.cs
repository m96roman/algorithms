using System.Collections.Generic;
using LeetCode.Domain;

namespace LeetCode
{
    public class ConvertSortedListToBinarySearchTree
    {
        public TreeNode SortedListToBST(ListNode head)
        {
            if (head is null)
            {
                return null;
            }

            var values = new List<int>();
            var iterator = head;

            while (iterator != null)
            {
                values.Add(iterator.val);
                iterator = iterator.next;
            }

            var result = CreateNodes(values, 0, values.Count - 1);

            return result;
        }

        private static TreeNode CreateNodes(List<int> values, int from, int to)
        {
            if (from > to)
            {
                return null;
            }

            var mid = (from + to + 1) / 2;

            return new TreeNode
            {
                val = values[mid],
                left = CreateNodes(values, from, mid - 1),
                right = CreateNodes(values, mid + 1, to)
            };
        }
    }
}
