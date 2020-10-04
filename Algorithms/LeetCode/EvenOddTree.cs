using System.Collections.Generic;

namespace LeetCode
{
    public class EvenOddTree
    {
        public bool IsEvenOddTree(TreeNode root) =>
            Do(root, 0, new Dictionary<int, int>());

        private static bool Do(TreeNode root, int level, IDictionary<int, int> levelToLastValueMap)
        {
            if (root == null)
            {
                return true;
            }

            var value = root.val;

            var isValidValue = level % 2 == 0
                ? value % 2 == 1 && (!levelToLastValueMap.ContainsKey(level) || value > levelToLastValueMap[level])
                : value % 2 == 0 && (!levelToLastValueMap.ContainsKey(level) || value < levelToLastValueMap[level]);

            if (!isValidValue)
            {
                return false;
            }

            levelToLastValueMap[level] = value;

            return
                Do(root.left, level + 1, levelToLastValueMap) &&
                Do(root.right, level + 1, levelToLastValueMap);
        }
    }
}
