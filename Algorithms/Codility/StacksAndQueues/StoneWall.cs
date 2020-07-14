using System.Collections.Generic;

namespace Codility.StacksAndQueues
{
    public class StoneWall
    {
        public int solution(int[] H)
        {
            var wall = new Stack<int>();
            var countOfBlocks = 0;

            foreach (var height in H)
            {
                while (wall.Count > 0 && wall.Peek() > height)
                {
                    wall.Pop();
                }

                if (wall.Count == 0 || wall.Peek() < height)
                {
                    wall.Push(height);
                    ++countOfBlocks;
                }
            }

            return countOfBlocks;
        }
    }
}
