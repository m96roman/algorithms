using System;
using System.Collections.Generic;
using System.Linq;
using Console = System.Console;

namespace Algotester
{
    public static class LuckyNumbersContest
    {
        public static class LuckyNumber
        {
            public static void Run()
            {
                Console.ReadLine();
                Console.WriteLine(7);
            }
        }

        public static class LuckySequence
        {
            public static void Run()
            {
                Console.ReadLine();
                var numbersStr = Console.ReadLine().Trim();
                var numbers = numbersStr.Split(' ').Select(int.Parse).ToArray();


                var isAscending = Enumerable.Range(1, numbers.Length - 1).All(i => numbers[i] >= numbers[i - 1]);

                if (isAscending)
                {
                    Console.WriteLine("YES");
                    return;
                }

                var isDescending = !Enumerable.Range(1, numbers.Length - 1).Any(i => numbers[i] > numbers[i - 1]);

                if (isDescending)
                {
                    Console.WriteLine("YES");
                    return;
                }

                Console.WriteLine("NO");
            }
        }

        public static class LuckOfLuckyNumber
        {
            public static void Run()
            {
                var input = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
                var n = input[0];
                var k = input[1];

                if (k % 3 != 0)
                {
                    Console.WriteLine(-1);
                    return;
                }

                if (k > (n - 1) * 3)
                {
                    Console.WriteLine(-1);
                    return;
                }

                var countOfDifferentDigits = k / 3 + 1;

                var result =
                    string.Join("", Enumerable.Repeat("7", n - countOfDifferentDigits)) +
                    string.Join("", Enumerable.Repeat("74", countOfDifferentDigits / 2)) +
                    (countOfDifferentDigits % 2 != 0 ? "7" : "");

                Console.WriteLine(result);
            }
        }

        public static class LuckyGroups
        {
            public static void Run()
            {
                var count = int.Parse(Console.ReadLine().Trim());
                var countOf47 = 0;

                for (var i = 0; i < count; ++i)
                {
                    var number = Console.ReadLine().Trim();
                    if (number.Contains("74"))
                    {
                        Console.WriteLine(-1);
                        return;
                    }

                    if (number.Contains("47"))
                    {
                        ++countOf47;
                    }
                }

                var result = Math.Max(countOf47, 1);

                Console.WriteLine(result);
            }
        }

        public static class LuckyRectangles
        {
            public static void Run()
            {
                var count = int.Parse(Console.ReadLine().Trim());

                Dictionary<int, List<int>> points = new Dictionary<int, List<int>>();

                for (var i = 0; i < count; ++i)
                {
                    var pointDims = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
                    var x = pointDims[0];
                    var y = pointDims[1];

                    if (!points.ContainsKey(x))
                    {
                        points[x] = new List<int>();
                    }

                    points[x].Add(y);
                }

                var countOfRectangles = 0;

                var values = points.Values.ToArray();

                for (var i = 0; i < values.Length; ++i)
                {
                    for (var j = i + 1; j < values.Length; ++j)
                    {
                        var countOfCommonPoints = values[i].Intersect(values[j]).Count();
                        countOfRectangles += (countOfCommonPoints * (countOfCommonPoints - 1)) / 2;
                    }
                }

                Console.WriteLine(countOfRectangles);

            }
        }
    }
}
