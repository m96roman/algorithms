using System.Collections.Generic;
using System.Linq;

namespace Codility.StacksAndQueues
{
    public class Fish
    {
        public int solution(int[] A, int[] B)
        {
            var river = new Stack<Shark>();

            foreach (var shark in A.Zip(B, (a, b) => new Shark { Size = a, Direction = (Direction)b }))
            {
                if (river.Count == 0)
                {
                    river.Push(shark);
                    continue;
                }

                var lastShark = river.Peek();
                if (lastShark.Direction == Direction.Upstream)
                {
                    river.Push(shark);
                    continue;
                }

                if (shark.Direction == Direction.Downstream)
                {
                    river.Push(shark);
                    continue;
                }

                while (shark.Size > lastShark.Size)
                {
                    river.Pop();

                    if (river.Count == 0)
                    {
                        river.Push(shark);
                        break;
                    }

                    lastShark = river.Peek();

                    if (lastShark.Direction == Direction.Upstream)
                    {
                        river.Push(shark);
                        break;
                    }
                }
            }

            return river.Count;
        }

        private class Shark
        {
            public int Size { get; set; }

            public Direction Direction { get; set; }
        }

        private enum Direction
        {
            Upstream,
            Downstream
        }
    }
}
