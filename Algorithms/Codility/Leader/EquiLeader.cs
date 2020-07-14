using System;
using System.Linq;

namespace Codility.Leader
{
    public class EquiLeader
    {
        public int solution(int[] A)
        {
            var leader = FindLeader(A);

            if (leader == null)
            {
                return 0;
            }

            var leaderValue = leader.Item1;
            var leaderCount = leader.Item2;

            var countOfLeftLeader = 0;
            var countOfEquiLeaders = 0;

            for (var i = 0; i < A.Length - 1; i++)
            {
                if (A[i] == leaderValue)
                {
                    ++countOfLeftLeader;
                }

                if (countOfLeftLeader > (i + 1) / 2 && leaderCount - countOfLeftLeader > (A.Length - i - 1) / 2)
                {
                    ++countOfEquiLeaders;
                }
            }

            return countOfEquiLeaders;
        }

        private Tuple<int, int> FindLeader(int[] A)
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

            return countOfLeader > A.Length / 2
                ? new Tuple<int, int>(candidateValue, candidateCount)
                : null;
        }
    }
}
