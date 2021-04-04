using System;
using System.Collections.Generic;
using System.Linq;
using Algorithms;

namespace Codility.PrefixSums
{
    public class GenomicRangeQuery
    {
        //Sample input
        //"CAGCCTA", new[] { 2, 5, 0 }, new[] { 4, 5, 6 }

        private static readonly Dictionary<string, int> ValueMap = new Dictionary<string, int>
        {
            ["A"] = 1,
            ["C"] = 2,
            ["G"] = 3,
            ["T"] = 4
        };

        public int[] solution(string S, int[] P, int[] Q)
        {
            var values = S
                .Select(it => ValueMap[it.ToString().ToUpper()])
                .ToArray();

            var tree = new SegmentTree<int>(values, Math.Min, int.MaxValue);
            var result = P.Select((_, i) => tree.CalculateOnRange(P[i], Q[i])).ToArray();

            return result;
        }
    }
}
