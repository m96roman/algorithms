using System.Linq;

namespace Codility.Sorting
{
    public class Triangle
    {
        public int solution(int[] A)
        {
            if (A.Length < 3)
            {
                return 0;
            }

            var sorted = A
                .OrderBy(it => it)
                .ToArray();


            for (var i = 0; i < sorted.Length - 2; ++i)
            {
                var first = sorted[i];
                var second = sorted[i + 1];
                var third = sorted[i + 2];

                var isTriangle =
                    (long)first + second > third &&
                    (long)second + third > first &&
                    (long)third + first > second;

                if (isTriangle)
                {
                    return 1;
                }
            }

            return 0;
        }
    }
}
