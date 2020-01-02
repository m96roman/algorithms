using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.StacksAndQueues
{
    public class Brackets
    {
        public int solution(String S)
        {
            var stack = new Stack<string>();

            var openBracesMap = new Dictionary<string, string>
            {
                {"{", "}" },
                {"(", ")" },
                {"[", "]" }
            };

            var closingBracesMap = new Dictionary<string, string>
            {
                { "}",  "{" },
                { ")" , "(" },
                { "]" , "[" }
            };

            var strSequence = false;

            foreach (var s in S)
            {
                var el = s.ToString();

                if (openBracesMap.ContainsKey(el))
                {
                    if (strSequence)
                    {
                        return 0;
                    }

                    stack.Push(el);
                }
                else if (closingBracesMap.ContainsKey(el))
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

                    strSequence = false;
                }
                else
                {
                    if (!strSequence)
                    {
                        if (stack.Count > 0)
                        {
                            var lastEl = stack.Peek();

                            if (!openBracesMap.ContainsKey(lastEl))
                            {
                                return 0;
                            }
                        }
                    }

                    strSequence = true;
                }
            }

            return stack.Count == 0 ? 1 : 0;
        }
    }
}
