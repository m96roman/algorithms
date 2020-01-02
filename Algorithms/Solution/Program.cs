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
            var result = new MaxCounters().solution(5, new[] {3, 4, 4, 6, 1, 4, 4});
            Console.WriteLine(string.Join(",", result));
            Console.ReadKey();
        }
    }
}
