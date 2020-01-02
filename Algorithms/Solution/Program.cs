using System;
using Algorithms;
using Codility.Arrays;
using Codility.Iterations;
using Codility.PrefixSums;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new BinaryGap().solution(32);
            Console.WriteLine(string.Join(",", result));
            Console.ReadKey();
        }
    }
}
