using System;
using System.Linq;

namespace Codility.BinarySearchAlgorithm
{
    public class MinMaxDivision
    {
        public int solution(int K, int M, int[] A)
        {
            var sumOfElements = A.Sum();
            var maxElement = A.Max();

            var lowerBound = Math.Max(maxElement, sumOfElements / K);
            var upperBound = sumOfElements;

            var result = upperBound;

            while (lowerBound <= upperBound)
            {
                var mid = (lowerBound + upperBound) / 2;

                var blockLength = mid + 1;
                var blocksCount = 0;

                foreach (var element in A)
                {
                    blockLength += element;

                    if (blockLength > mid)
                    {
                        ++blocksCount;
                        blockLength = element;
                    }

                    if (blocksCount > K)
                    {
                        break;
                    }
                }

                if (blocksCount > K)
                {
                    lowerBound = mid + 1;
                }
                else
                {
                    upperBound = mid - 1;
                    result = mid;
                }
            }

            return result;
        }
    }
}
