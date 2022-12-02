namespace LeetCode
{
    public class LongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            var length = s.Length;

            var dp = new bool[length][];

            for(var i = 0; i < length; ++i)
            {
                dp[i] = new bool[length];
            }

            int longestB = 0;
            int longestE = 0;

            for(var i = 0; i < length; ++i)
            {
                for(var j = 0; j < length - i; ++j)
                {
                    var b = j;
                    var e = j + i;

                    if (b == e)
                    {
                        dp[b][e] = true;
                    } 
                    else if (e - b == 1)
                    {
                        dp[b][e] = s[b] == s[e];
                    }
                    else
                    {
                        dp[b][e] = s[b] == s[e] && dp[b + 1][e - 1];
                    }


                    // update longest

                    if (dp[b][e] && (e - b) > (longestE - longestB))
                    {
                        longestB = b;
                        longestE = e;
                    }
                }
            }

            return s.Substring(longestB, longestE - longestB + 1);
        }
    }
}
