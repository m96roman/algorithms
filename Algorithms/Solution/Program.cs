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
            var result = new FrogRiverOne().solution(5, new []{1, 3, 1, 4, 2, 3, 5, 4});
            Console.WriteLine(string.Join(",", result));
            Console.ReadKey();
        }
    }
}
