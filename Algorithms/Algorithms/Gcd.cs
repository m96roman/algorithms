using System;
using System.Linq;

namespace Algorithms
{
    public static class Gcd
    {
        public static int Calculate(params int[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException(nameof(numbers));
            }

            if (!numbers.Any())
            {
                throw new ArgumentException("Array should contain at least one element", nameof(numbers));
            }

            return numbers.Length == 1
                ? numbers[0]
                : numbers.Aggregate(numbers[1], GcdOfTwo);
        }

        private static int GcdOfTwo(int a, int b)
        {
            if (a == 0)
            {
                return b;
            }

            return GcdOfTwo(b % a, a);
        }
    }
}
