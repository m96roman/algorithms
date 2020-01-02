using System;
using Algorithms;
using Codility.Arrays;
using Codility.CountingElements;
using Codility.Iterations;
using Codility.PrefixSums;
using Codility.StacksAndQueues;
using Codility.TimeComplexity;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new PermCheck().solution(new[] {1, 3, 4, 8});
            Console.WriteLine(string.Join(",", result));
            Console.ReadKey();
        }
    }
}
