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
            var result = new OddOccurrencesInArray().solution(new []{9, 3, 9, 3, 9, 9, 7});
            Console.WriteLine(string.Join(",", result));
            Console.ReadKey();
        }
    }
}
