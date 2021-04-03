using System.Collections;
using System.Linq;

namespace Codility.CountingElements
{
    public class MissingInteger
    {
        public int solution(int[] A)
        {
            const int maxValue = 1000001;

            var map = new BitArray(maxValue);
            
            foreach (var a in A.Where(it => it > 0))
            {
                map[a] = true;
            }

            for (var i = 1; i < map.Length; ++i)
            {
                if (map[i] == false)
                {
                    return i;
                }
            }

            return maxValue;
        }
    }
}
