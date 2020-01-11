using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codility.Leader
{
    public class Dominator
    {
        public int solution(int[] A)
        {
            var size = 0;
            var value = -1;

            foreach (var el in A)
            {
                if (size == 0)
                {
                    value = el;
                    ++size;
                }
                else if(value != el)
                {
                    --size;
                }
            }

            var countOfLeader = A.Count(it => it == value);

            if (countOfLeader > A.Length / 2)
            {
                return Array.IndexOf(A, value);
            }

            return -1;
        }
    }
}
