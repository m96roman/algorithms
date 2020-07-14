using System;

namespace Codility.PrimeAndCompositeNumbers
{
    public class MinPerimeterRectangle
    {
        public int solution(int N)
        {
            for (var i = (int)Math.Sqrt(N); i >= 1; --i)
            {
                if (N % i == 0)
                {
                    return 2 * (i + N / i);
                }
            }

            return 0;
        }
    }
}
