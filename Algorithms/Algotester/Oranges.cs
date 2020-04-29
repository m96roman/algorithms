using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Algotester
{
    public class Oranges
    {
        public void Run()
        {
            var str = Regex.Replace(Console.ReadLine().Trim(), "[ ]{2,}", " ");
            var counts = str.Split(" ").Select(long.Parse).ToArray();

            var result = counts[0] + counts[1] > counts[2] ? "YES" : "NO";

            Console.WriteLine(result);
        }
    }
}
