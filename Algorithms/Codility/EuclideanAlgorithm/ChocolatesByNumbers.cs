using Algorithms;

namespace Codility.EuclideanAlgorithm
{
    public class ChocolatesByNumbers
    {
        public int solution(int N, int M)
        {
            return N / Gcd.Calculate(N, M);
        }
    }
}
