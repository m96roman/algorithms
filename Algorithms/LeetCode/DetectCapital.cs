using System.Linq;

namespace LeetCode
{
    public class DetectCapital
    {
        public bool DetectCapitalUse(string word)
        {
            if (word.Length == 1)
            {
                return true;
            }

            return char.IsUpper(word[0]) && char.IsUpper(word[1])
                ? word.Skip(2).All(char.IsUpper)
                : word.Skip(1).All(char.IsLower);
        }
    }
}
