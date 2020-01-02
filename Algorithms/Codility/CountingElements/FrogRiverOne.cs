using System.Collections;

namespace Codility.CountingElements
{
    public class FrogRiverOne
    {
        public int solution(int X, int[] A)
        {
            var leaves = new BitArray(X);
            var countOfLeaves = 0;

            for (var i = 0; i < A.Length; ++i)
            {
                var el = A[i] - 1;
                if (leaves[el] == false)
                {
                    leaves[el] = true;
                    ++countOfLeaves;
                }

                if (countOfLeaves == X)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
