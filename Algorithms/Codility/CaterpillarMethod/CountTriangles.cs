using System.Linq;

namespace Codility.CaterpillarMethod
{
    public class CountTriangles
    {
        public int solution(int[] A)
        {
            if (A.Length < 3)
            {
                return 0;
            }

            var orderedSequence = A
                .OrderBy(it => it)
                .ToArray();

            var countOfTriangles = 0;

            for (var firstV = 0; firstV < orderedSequence.Length - 2; ++firstV)
            {
                var thirdV = firstV + 2;

                for (var secondV = firstV + 1; secondV < orderedSequence.Length - 1; ++secondV)
                {
                    while (thirdV < orderedSequence.Length &&  orderedSequence[firstV] + orderedSequence[secondV] > orderedSequence[thirdV])
                    {
                        ++thirdV;
                    }

                    countOfTriangles += thirdV - secondV - 1;
                }
            }

            return countOfTriangles;
        }
    }
}
