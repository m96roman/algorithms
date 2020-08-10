using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class MakeTheStringGreat
    {
        public string MakeGood(string s)
        {
            var stack = new Stack<char>();

            foreach (var symbol in s)
            {
                if (!stack.Any() || stack.Peek() == symbol || char.ToLower(stack.Peek()) != char.ToLower(symbol))
                {
                    stack.Push(symbol);
                }
                else
                {
                    stack.Pop();
                }
            }

            return string.Join("", stack.ToArray().Reverse());
        }
    }
}
