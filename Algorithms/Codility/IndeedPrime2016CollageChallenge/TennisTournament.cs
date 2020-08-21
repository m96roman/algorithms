using System;

namespace Codility.IndeedPrime2016CollageChallenge
{
    public class TennisTournament
    {
        public int solution(int P, int C)
        {
            return Math.Min(C, P / 2);
        }
    }
}
