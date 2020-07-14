using System;
using System.Linq;

namespace Codility.Leader
{
    public class Dominator
    {
        public int solution(int[] A)
        {
            var candidateCount = 0;
            var candidateValue = -1;

            foreach (var el in A)
            {
                if (candidateCount == 0)
                {
                    candidateValue = el;
                    ++candidateCount;
                }
                else if (candidateValue != el)
                {
                    --candidateCount;
                }
                else
                {
                    ++candidateCount;
                }
            }

            var countOfLeader = A.Count(it => it == candidateValue);

            if (countOfLeader > A.Length / 2)
            {
                return Array.IndexOf(A, candidateValue);
            }

            return -1;
        }
    }
}