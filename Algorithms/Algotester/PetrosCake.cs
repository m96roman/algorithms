using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Algotester
{
    public class PetrosCake
    {
        public void Run()
        {
            var input = Console.ReadLine()
                .Trim()
                .Split(" ")
                .Select(double.Parse)
                .ToArray();

            var count = input[0];
            var radius = input[1];

            var result = radius / Math.Sqrt(count);
            Console.WriteLine(result);
        }
    }
}
