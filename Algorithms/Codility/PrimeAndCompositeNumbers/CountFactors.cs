using System;

namespace Codility.PrimeAndCompositeNumbers
{
    public class CountFactors
    {
        public int solution(int N)
        {
            var factorsCount = 0;
            var sqrt = Math.Sqrt(N);

            for (var i = 1; i < sqrt; ++i)
            {
                if (N % i == 0)
                {
                    factorsCount += 2;
                }
            }

            if ((int)sqrt * (int)sqrt == N)
            {
                factorsCount += 1;
            }

            return factorsCount;
        }
    }
}
