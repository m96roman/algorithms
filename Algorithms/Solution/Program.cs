using System;
using Codility.PrefixSums;
using Codility.Sorting;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Triangle().solution(new[] {10, 2, 5, 1, 8, 20});

            Console.WriteLine(string.Join(",", result));
            Console.ReadKey();
        }
    }
}
