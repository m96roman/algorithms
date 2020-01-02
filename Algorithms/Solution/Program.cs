using System;
using Algorithms;
using Codility.Arrays;
using Codility.Iterations;
using Codility.PrefixSums;
using Codility.StacksAndQueues;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Brackets().solution("7");
            Console.WriteLine(string.Join(",", result));
            Console.ReadKey();
        }
    }
}
