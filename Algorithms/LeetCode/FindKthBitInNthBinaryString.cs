using System.Linq;

namespace LeetCode
{
    public class FindKthBitInNthBinaryString
    {
        public char FindKthBit(int n, int k)
        {
            char[] Inverse(char[] bits) => bits.Select(it => it == '0' ? '1' : '0').ToArray();
            char[] Reverse(char[] bits) => bits.Reverse().ToArray();
            string Join(char[] bits) => string.Join("", bits);

            string GenerateBinaryString(int step)
            {
                if (step == 1)
                {
                    return "0";
                }

                var previous = GenerateBinaryString(step - 1);

                return previous + "1" + Join(Inverse(Reverse(previous.ToCharArray())));
            }

            var generated = GenerateBinaryString(n);
            return generated[k - 1];
        }
    }
}
