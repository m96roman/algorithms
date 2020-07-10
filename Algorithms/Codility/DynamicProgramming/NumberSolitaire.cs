using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codility.DynamicProgramming
{
    public class NumberSolitaire
    {
        public int solution(int[] A)
        {
            var results = Enumerable.Repeat(int.MinValue, 6).ToArray();
            results[0] = A[0];
            
            for (var i = 1; i < A.Length; ++i)
            {
                results[i % 6] = results.Max() + A[i];
            }

            return results[(A.Length - 1) % 6];
        }
    }
}
