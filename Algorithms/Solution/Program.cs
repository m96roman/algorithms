using System;
using System.Linq;
using Codility.Leader;
using Codility.MaximumSliceProblem;
using Codility.PrefixSums;
using Codility.Sorting;
using Codility.StacksAndQueues;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new MaxProfit().solution(new[] {23171, 21011, 21123, 21366, 21013, 21367});

            
  
            Console.WriteLine(string.Join(",", result));
            Console.ReadKey();
        }
    }
}
