using System;
using System.Collections.Generic;
using System.Linq;

namespace Codility.IndeedPrime2015Challenge
{
    public class FloodDepth
    {
        public int solution(int[] A)
        {
            var stack = new Stack<Area>();
            var maxDepth = 0;

            foreach (var height in A)
            {
                if (!stack.Any() || height < stack.Peek().Max)
                {
                    stack.Push(new Area(height));
                    continue;
                }

                while (stack.Any() && height > stack.Peek().Max)
                {
                    if (stack.Count == 1)
                    {
                        var area = stack.Pop();
                        maxDepth = Math.Max(maxDepth, area.Max - area.Min);

                        stack.Push(new Area(height));

                        break;
                    }

                    var valley = stack.Pop().Min;
                    var previousBlock = stack.Pop();

                    if (height > previousBlock.Max)
                    {
                        stack.Push(new Area(previousBlock.Max, Math.Min(previousBlock.Min, valley)));
                    }
                    else if (height < previousBlock.Max)
                    {
                        stack.Push(previousBlock);
                        stack.Push(new Area(height, Math.Min(height, valley)));
                    }
                    else
                    {
                        stack.Push(new Area(height, Math.Min(previousBlock.Min, valley)));
                    }
                }
            }

            while (stack.Any())
            {
                var area = stack.Pop();
                maxDepth = Math.Max(maxDepth, area.Max - area.Min);
            }

            return maxDepth;
        }

        public int solution2(int[] A)
        {
            var highest = 0;
            var lowest = 0;
            var maxDepth = 0;

            foreach (var height in A)
            {
                if (height < lowest)
                {
                    lowest = height;
                }
                else if (height >= highest)
                {
                    maxDepth = Math.Max(maxDepth, highest - lowest);

                    highest = height;
                    lowest = height;
                }
                else if (height > lowest)
                {
                    maxDepth = Math.Max(maxDepth, height - lowest);
                }
            }

            return maxDepth;
        }

        public class Area
        {
            public Area(int max, int min)
            {
                Max = max;
                Min = min;
            }

            public Area(int max)
            {
                Max = max;
                Min = max;
            }

            public int Max { get; }
            public int Min { get; }
        }
    }
}
