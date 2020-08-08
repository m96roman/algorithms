namespace LeetCode
{
    public class MinimumInsertionsToBalanceAParenthesesString
    {
        public int MinInsertions(string s)
        {
            var str = s.Replace("))", "]");

            var leftBraces = 0;
            var countOfNeededBraces = 0;

            foreach (var brace in str)
            {
                if (brace == '(')
                {
                    ++leftBraces;
                }
                else
                {
                    if (brace == ')')
                    {
                        ++countOfNeededBraces;
                    }

                    if (leftBraces == 0)
                    {
                        ++countOfNeededBraces;
                    }
                    else
                    {
                        --leftBraces;
                    }
                }
            }

            countOfNeededBraces += leftBraces * 2;

            return countOfNeededBraces;
        }
    }
}
