using System;

namespace Codility.Iterations
{
    public class BinaryGap
    {
        public int solution(int N)
        {
            var zeroCount = -1;
            var maxZeroCount = 0;

            while (N >= 1)
            {
                var binaryDigit = N % 2;

                if (binaryDigit == 0 && zeroCount != -1)
                {
                    zeroCount++;
                }
                else if (binaryDigit == 1)
                {
                    maxZeroCount = Math.Max(maxZeroCount, zeroCount);
                    zeroCount = 0;
                }

                N /= 2;
            }

            return maxZeroCount;
        }
    }
}
