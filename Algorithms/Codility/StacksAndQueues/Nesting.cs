using System.Collections.Generic;

namespace Codility.StacksAndQueues
{
    public class Nesting
    {
        public int solution(string S)
        {
            var stack = new Stack<string>();

            foreach (var s in S)
            {
                var el = s.ToString();

                if (el == ")")
                {
                    if (stack.Count == 0)
                    {
                        return 0;
                    }

                    var lastEl = stack.Pop();

                    if (lastEl != "(")
                    {
                        return 0;
                    }
                }
                else
                {
                    stack.Push(el);
                }
            }

            return stack.Count == 0 ? 1 : 0;
        }
    }
}
