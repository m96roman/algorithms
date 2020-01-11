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
            var result = new StoneWall().solution(new []{8, 8, 5, 7, 9, 8, 7, 4, 8});

            Console.WriteLine(string.Join(",", result));
            Console.ReadKey();
        }
    }
}
