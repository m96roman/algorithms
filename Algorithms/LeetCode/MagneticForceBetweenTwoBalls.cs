using System.Linq;
using Algorithms;

namespace LeetCode
{
    public class MagneticForceBetweenTwoBalls
    {
        public int MaxDistance(int[] position, int m)
        {
            var orderedPositions = position.OrderBy(it => it).ToArray();

            var lowerBound = 0;
            var upperBound = orderedPositions.Last();

            return BinarySearch.SearchMax(lowerBound, upperBound, (mid) =>
            {
                var basketsUsed = 1;
                var lastBasketPosition = orderedPositions.First();

                foreach (var pos in orderedPositions.Skip(1))
                {
                    if (pos - lastBasketPosition >= mid)
                    {
                        ++basketsUsed;
                        lastBasketPosition = pos;
                    }
                }

                return basketsUsed >= m;
            });
        }
    }
}
