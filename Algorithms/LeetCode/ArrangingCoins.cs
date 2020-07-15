using System;

namespace LeetCode
{
    public class ArrangingCoins
    {
        public int ArrangeCoins(int n)
        {
            return (int)(-1 + Math.Sqrt(1 + 8L * n)) / 2;
        }
    }
}
