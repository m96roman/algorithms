using System;
using Algorithms;
using Codility.Arrays;
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
            var result = new TapeEquilibrium().solution(new[] {1, 2, 3, 4, 5});
            Console.WriteLine(string.Join(",", result));
            Console.ReadKey();
        }
    }
}
