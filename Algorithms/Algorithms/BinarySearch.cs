using System;

namespace Algorithms
{
    public static class BinarySearch
    {
        public enum Action
        {
            Stop,
            MoveRight,
            MoveLeft
        }

        public class StepResult
        {
            public Action NextAction { get; set; }
            public bool Success { get; set; }
        }

        public static int Search(int start, int end, Func<int, bool, StepResult> predicate)
        {
            var lastSuccess = - 1;

            while (start <= end)
            {
                var mid = (start + end) / 2;

                var result = predicate(mid, start == end);

                if (result.Success)
                {
                    lastSuccess = mid;
                }

                switch (result.NextAction)
                {
                    case Action.Stop:
                        return lastSuccess;
                    case Action.MoveLeft:
                        end = mid - 1;
                        break;
                    case Action.MoveRight:
                        start = mid + 1;
                        break;
                }
            }

            return lastSuccess;
        }
    }
}
