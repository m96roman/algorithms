namespace Codility.GreedyAlgorithms
{
    public class TieRopes
    {
        public int solution(int K, int[] A)
        {
            var countOfRopes = 0;
            var lastLength = 0;

            foreach (var ropeLength in A)
            {
                lastLength += ropeLength;

                if (lastLength >= K)
                {
                    ++countOfRopes;
                    lastLength = 0;
                }
            }

            return countOfRopes;
        }
    }
}
