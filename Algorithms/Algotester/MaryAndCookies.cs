using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Algotester
{
    public class MaryAndCookies
    {
        public void Run()
        {
            Console.ReadLine();
            var str = Regex.Replace(Console.ReadLine(), "[ ]{2,}", " ");

            var result = str.Trim().Split()
                .Select(it => long.Parse(it))
                .Sum(it => it > 1 ? it - 1 : 0);

            Console.WriteLine(result);
        }
    }
}
