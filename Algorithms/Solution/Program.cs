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
            var result = new NumberOfDiscIntersections().solution(new[] { 1, 2147483647, 0 });

            Console.WriteLine(string.Join(",", result));
            Console.ReadKey();
        }
    }
}
