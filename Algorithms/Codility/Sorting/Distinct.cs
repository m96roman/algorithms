using System.Collections.Generic;

namespace Codility.Sorting
{
    public class Distinct
    {
        public int solution(int[] A)
        {
            var set = new HashSet<int>();
            foreach (var el in A)
            {
                set.Add(el);
            }

            return set.Count;
        }
    }
}
