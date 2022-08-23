using System.Collections.Generic;

namespace LeetCode
{
    public class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            var map = new Dictionary<string, int>
            {
                ["M"] = 1000,
                ["CM"] = 900,
                ["D"] = 500,
                ["CD"] = 400,
                ["C"] = 100,
                ["XC"] = 90,
                ["L"] = 50,
                ["XL"] = 40,
                ["X"] = 10,
                ["IX"] = 9,
                ["V"] = 5,
                ["IV"] = 4,
                ["I"] = 1
            };

            var result = 0;

            for (var i = 0; i < s.Length; )
            {
                var key = i + 1 < s.Length && map.ContainsKey(s[i..(i + 2)])
                    ? s[i..(i + 2)]
                    : s[i..(i + 1)];

                result += map[key];
                i += key.Length;
            }

            return result;
        }
    }
}
