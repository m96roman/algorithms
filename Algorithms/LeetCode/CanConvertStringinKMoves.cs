namespace LeetCode
{
    public class CanConvertStringInKMoves
    {
        public bool CanConvertString(string s, string t, int k)
        {
            const int lettersCount = 26;

            if (s.Length != t.Length)
            {
                return false;
            }

            var shiftUsage = new int[27];
            for (var i = 0; i < s.Length; ++i)
            {
                if (s[i] == t[i])
                {
                    continue;
                }

                var shift = t[i] > s[i] ? t[i] - s[i] : lettersCount - (s[i] - t[i]);
                shiftUsage[shift] += 1;

                if ((shiftUsage[shift] - 1) * lettersCount + shift > k)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
