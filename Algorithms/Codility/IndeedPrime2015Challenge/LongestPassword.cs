using System.Linq;

namespace Codility.IndeedPrime2015Challenge
{
    public class LongestPassword
    {
        public int solution(string S)
        {
            var validPasswords = S.Split(' ')
                .Select(it => it.Trim())
                .Where(IsValidPassword)
                .ToArray();

            return validPasswords.Length > 0
                ? validPasswords.Max(it => it.Length)
                : -1;


            bool IsValidPassword(string s)
            {
                var countLetters = 0;
                var countDigits = 0;

                foreach (var character in s)
                {
                    if (!char.IsLetterOrDigit(character))
                    {
                        return false;
                    }

                    if (char.IsLetter(character))
                    {
                        ++countLetters;
                    }

                    if (char.IsDigit(character))
                    {
                        ++countDigits;
                    }
                }

                return (countLetters & 1) == 0 && (countDigits & 1) == 1;
            }
        }
    }
}
