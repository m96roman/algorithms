using System;
using System.Collections.Generic;
using System.Linq;

namespace Codility.StacksAndQueues
{
    public class Fish
    {
        public int solution(int[] A, int[] B)
        {
            var river = new Stack<Shark>();
            var countOfUpstreamFish = 0;

            foreach (var shark in A.Zip(B, (a, b) => new Shark { Size = a, Direction = (Direction)b }))
            {
                if (shark.Direction == Direction.Upstream)
                {
                    while (river.Count != 0 && shark.Size > river.Peek().Size)
                    {
                        river.Pop();
                    }

                    if (river.Count == 0)
                    {
                        ++countOfUpstreamFish;
                    }
                }
                else
                {
                    river.Push(shark);
                }
            }

            var countOfDownstreamFish = river.Count;

            return countOfDownstreamFish + countOfUpstreamFish;
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
