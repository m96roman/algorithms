using System;
using System.Collections.Generic;

namespace Codility.CaterpillarMethod
{
    public class AbsDistinct
    {
        public int solution(int[] A)
        {
            var set = new HashSet<int>();
            foreach (var el in A)
            {
                set.Add(el == int.MinValue ? el : Math.Abs(el));
            }

            return set.Count;
        }
    }
}
