using System.Collections;

namespace Codility.CountingElements
{
    public class PermCheck
    {
        public int solution(int[] A)
        {
            var presenceArray = new BitArray(A.Length);

            foreach (var i in A)
            {
                var el = i - 1;

                if (el >= A.Length)
                {
                    return 0;
                }

                presenceArray[el] = true;
            }

            foreach (bool el in presenceArray)
            {
                if (!el)
                {
                    return 0;
                }
            }

            return 1;
        }
    }
}
