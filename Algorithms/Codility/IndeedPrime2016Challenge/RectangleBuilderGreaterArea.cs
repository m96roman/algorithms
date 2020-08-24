﻿using System.Collections.Generic;
using System.Linq;
using Algorithms;

namespace Codility.IndeedPrime2016Challenge
{
    public class RectangleBuilderGreaterArea
    {
        public int solution(int[] A, int X)
        {
            var pieces = new Dictionary<int, int>();

            foreach (var el in A)
            {
                if (pieces.ContainsKey(el))
                {
                    pieces[el] += 1;
                }
                else
                {
                    pieces.Add(el, 1);
                }
            }

            var fenceCount = 0;
            var usablePieces = new List<int>();

            foreach (var pair in pieces)
            {
                if (pair.Value < 2)
                {
                    continue;
                }

                usablePieces.Add(pair.Key);

                if (pair.Value >= 4 && (long)pair.Key * (long)pair.Key >= (long)X)
                {
                    fenceCount += 1;
                }
            }

            var orderedPieces = usablePieces.OrderBy(it => it).ToArray();

            for (var i = 0; i < orderedPieces.Length; ++i)
            {
                var lowerBound = i + 1;
                var upperBound = orderedPieces.Length - 1;

                var value = BinarySearch.SearchMin(lowerBound, upperBound, (mid) =>
                {
                    return (long)orderedPieces[mid] * (long)orderedPieces[i] >= (long)X;
                });

                if (value != -1)
                {
                    fenceCount += (orderedPieces.Length - value);
                }

                if (fenceCount > 1000000000)
                {
                    return -1;
                }
            }

            return fenceCount;
        }
    }
}
