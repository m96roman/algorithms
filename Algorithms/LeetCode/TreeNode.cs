using System.Collections.Generic;

namespace LeetCode
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class TreeNodeComparer : IEqualityComparer<TreeNode>
    {
        public bool Equals(TreeNode x, TreeNode y)
        {
            if (ReferenceEquals(x, y)) return true;

            if (ReferenceEquals(x, null)) return false;
            if (ReferenceEquals(y, null)) return false;

            return x.val == y.val && Equals(x.left, y.left) && Equals(x.right, y.right);
        }

        public int GetHashCode(TreeNode obj)
        {
            unchecked
            {
                var hashCode = obj.val;
                hashCode = (hashCode * 397) ^ (obj.left != null ? obj.left.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (obj.right != null ? obj.right.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}
