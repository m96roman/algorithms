namespace LeetCode
{
    public class RotateImage
    {
        public void Rotate(int[][] matrix)
        {
            var n = matrix.Length;

            for (var i = 0; i < n / 2; ++i)
            {
                for (var j = 1; j < n - i * 2; ++j)
                {
                    var remember = matrix[i + j][i];
                    var last = n - i - 1;

                    matrix[i + j][i] = matrix[last][i + j];
                    matrix[last][i + j] = matrix[last - j][last];
                    matrix[last - j][last] = matrix[i][last - j];
                    matrix[i][last - j] = remember;
                }
            }
        }
    }
}
