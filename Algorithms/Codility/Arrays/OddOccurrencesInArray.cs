using System.Linq;

namespace Codility.Arrays
{
    public class OddOccurrencesInArray
    {
        public int solution(int[] A)
        {
            return A.GroupBy(it => it).Single(it => it.Count() % 2 == 1).Key;
        }
    }
}
