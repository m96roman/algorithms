namespace LeetCode
{
    public class ShuffleString
    {
        public string RestoreString(string s, int[] indices)
        {
            var charArray = new char[s.Length];
            for (var i = 0; i < s.Length; ++i)
            {
                charArray[indices[i]] = s[i];
            }

            return string.Join("", charArray);
        }
    }
}
