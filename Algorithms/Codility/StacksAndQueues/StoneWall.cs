using System.Collections.Generic;
using System.Linq;

namespace Codility.StacksAndQueues
{
    public class StoneWall
    {
        public int solution(int[] H)
        {
            var wall = new Stack<int>();

            wall.Push(H.First());
            var countOfBlocks = 1;
            
            foreach (var height in H.Skip(1))
            {
                var lastBlock = wall.Peek();

                if (lastBlock < height)
                {
                    wall.Push(height);
                    ++countOfBlocks;
                }
                else if (lastBlock > height)
                {
                    do
                    {
                        wall.Pop();
                    }
                    while (wall.Count > 0 && wall.Peek() > height);

                    if (wall.Count == 0 || wall.Peek() < height)
                    {
                        wall.Push(height);
                        ++countOfBlocks;
                    }
                }
            }

            return countOfBlocks;
        }
    }
}
