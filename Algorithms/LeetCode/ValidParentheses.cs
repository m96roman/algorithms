using System.Collections.Generic;

namespace LeetCode
{
    public class ValidParentheses
    {
        Dictionary<char, char> map = new Dictionary<char, char>
        {
            ['('] = ')',
            ['['] = ']',
            ['{'] = '}'
        };

        public bool IsValid(string s)
        {
            var result = IsValidRecurse(s, 0);

            return result == s.Length;
        }

        private int IsValidRecurse(string s, int index)
        {
            if(index == s.Length || !map.ContainsKey(s[index]))
            {
                return index;
            }

            var closingIndex = IsValidRecurse(s, index + 1);

            return closingIndex >= 0 && closingIndex < s.Length && s[closingIndex] == map[s[index]]
                ? IsValidRecurse(s, closingIndex + 1)
                : -1;
        }
    }
}
