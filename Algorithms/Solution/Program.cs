using System;
using Algorithms;
using Codility.Arrays;
using Codility.PrefixSums;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new CyclicRotation().solution(new[] {3, 8, 9, 7, 6}, 4);
            Console.WriteLine(string.Join(",", result));
            Console.ReadKey();
        }
    }
}
