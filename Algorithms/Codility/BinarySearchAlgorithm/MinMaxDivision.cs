using System;
using System.Linq;
using Algorithms;

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

            return BinarySearch.SearchMin(lowerBound, upperBound, (mid) =>
            {
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

                return blocksCount <= K;
            });
        }
    }
}
