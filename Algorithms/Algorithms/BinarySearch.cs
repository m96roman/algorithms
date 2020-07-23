using System;

namespace Algorithms
{
    public static class BinarySearch
    {
        public enum Action
        {
            Found,
            MoveRight,
            MoveLeft,
            NotFound
        }

        public static int Search(int start, int end, Func<int, bool, Action> predicate)
        {
            var mid = -1;

            while (start <= end)
            {
                mid = (start + end) / 2;

                var result = predicate(mid, start == end);

                switch (result)
                {
                    case Action.Found:
                        return mid;
                    case Action.NotFound:
                        return -1;
                    case Action.MoveLeft:
                        end = mid - 1;
                        break;
                    case Action.MoveRight:
                        start = mid + 1;
                        break;
                }
            }

            return mid;
        }
    }
}
