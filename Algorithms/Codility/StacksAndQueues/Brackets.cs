using System;
using System.Collections.Generic;

namespace Codility.StacksAndQueues
{
    public class Brackets
    {
        public int solution(String S)
        {
            var stack = new Stack<string>();

            var closingBracesMap = new Dictionary<string, string>
            {
                { "}",  "{" },
                { ")" , "(" },
                { "]" , "[" }
            };

            foreach (var s in S)
            {
                var el = s.ToString();

                if (closingBracesMap.ContainsKey(el))
                {
                    if (stack.Count == 0)
                    {
                        return 0;
                    }

                    var lastEl = stack.Pop();
                    var openEl = closingBracesMap[el];

                    if (lastEl != openEl)
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
