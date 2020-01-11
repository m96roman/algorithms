using System;
using System.Linq;
using Codility.PrefixSums;
using Codility.Sorting;
using Codility.StacksAndQueues;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Nesting().solution("(()()");

            Console.WriteLine(string.Join(",", result));
            Console.ReadKey();
        }
    }
}
