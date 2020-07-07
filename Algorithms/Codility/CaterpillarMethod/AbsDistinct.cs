using System;
using System.Collections.Generic;
using System.Linq;

namespace Codility.CaterpillarMethod
{
    public class AbsDistinct
    {
        public int solutionWithSet(int[] A)
        {
            var set = new HashSet<int>();
            foreach (var el in A)
            {
                set.Add(el == int.MinValue ? el : Math.Abs(el));
            }

            return set.Count;
        }

        public int solution(int[] A)
        {
            var sequence = A
                .SkipWhile(it => it == int.MinValue)
                .ToArray();

            var left = 0;
            var right = sequence.Length - 1;

            var absDistinctCount = A.Length - sequence.Length;
            
            while (left <= right)
            {
                while (left + 1 <= right && sequence[left] == sequence[left + 1])
                {
                    ++left;
                }

                while (right - 1 >= left && sequence[right] == sequence[right - 1])
                {
                    --right;
                }

                var lAbs = Math.Abs(sequence[left]);
                var rAbs = Math.Abs(sequence[right]);

                ++absDistinctCount;

                left += lAbs >= rAbs ? 1 : 0;
                right -= lAbs <= rAbs ? 1 : 0;
            }

            return absDistinctCount;
        }
    }
}
