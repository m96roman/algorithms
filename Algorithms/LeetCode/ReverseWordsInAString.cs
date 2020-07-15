using System.Linq;
using System.Text.RegularExpressions;

namespace LeetCode
{
    public class ReverseWordsInAString
    {
        public string ReverseWords(string s)
        {
            return string.Join(" ", Regex.Replace(s.Trim(), "[ ]{2,}", " ").Split(' ').Reverse());
        }
    }
}
