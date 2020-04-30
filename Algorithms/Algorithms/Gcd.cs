using System;
using System.Linq;

namespace Algorithms
{
    static class Gcd
    {
        public static int Calculate(int[] numbers)
        {
            if(!numbers.Any())
            {
                throw new ArgumentException("empty array");
            }

            return numbers.Aggregate(numbers[1], (gcd, item) => GcdOfTwo(gcd, item));
        }

        private static int GcdOfTwo(int a, int b)
        {
            if(a == 0)
            {
                return b;
            }

            return GcdOfTwo(b % a, a);
        }
    }
}
