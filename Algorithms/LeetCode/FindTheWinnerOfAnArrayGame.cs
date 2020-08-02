namespace LeetCode
{
    public class FindTheWinnerOfAnArrayGame
    {
        public int GetWinner(int[] arr, int k)
        {
            var winner = arr[0];
            var wins = 0;

            for (var i = 1; i < arr.Length; ++i)
            {
                if (wins == k)
                {
                    break;
                }

                if (winner > arr[i])
                {
                    ++wins;
                }
                else
                {
                    winner = arr[i];
                    wins = 1;
                }
            }

            return winner;
        }
    }
}
