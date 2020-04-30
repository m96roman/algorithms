using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Algotester
{
    public static class AlgotesterSolutions1
    {
        public class BorsсhPotatoSalad
        {
            public void Run()
            {
                var friendsCount = int.Parse(Console.ReadLine());
                int A = 0, B = 0, C = 0;
                var wishes = new int[friendsCount][];

                for (var i = 0; i < friendsCount; ++i)
                {
                    var str = Regex.Replace(Console.ReadLine(), "[ ]{2,}", " ");
                    var friendWish = str.Split(" ").Select(int.Parse).ToArray();
                    wishes[i] = friendWish;

                    A += friendWish[0];
                    B += friendWish[1];
                    C += friendWish[2];
                }

                var a = A / friendsCount;
                var b = B / friendsCount;
                var c = C / friendsCount;


                var complaint = 0;

                for (var i = 0; i < friendsCount; ++i)
                {
                    complaint =
                        Math.Abs(wishes[i][0] - a) +
                        Math.Abs(wishes[i][1] - b) +
                        Math.Abs(wishes[i][2] - c);
                }

                Console.WriteLine(complaint);
            }
        }

        public class DeputyMoney
        {
            public void Run()
            {
                var input = Console.ReadLine();
                var money = int.Parse(input.Trim());

                var bills = new int[] { 500, 200, 100, 50, 20, 10, 5, 2, 1 };

                var billsCount = 0;
                while (money > 0)
                {
                    for (var i = 0; i < bills.Length; ++i)
                    {
                        if (money >= bills[i])
                        {
                            money -= bills[i];
                            billsCount += 1;
                            break;
                        }
                    }
                }

                Console.WriteLine(billsCount);
            }
        }

        public class ElephantsCoach
        {
            public void Run()
            {
                Console.ReadLine();

                var postionsInput = Regex.Replace(Console.ReadLine().Trim(), "[ ]{2,}", " ");
                var positions = postionsInput
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                var orderedPositions = positions
                    .OrderBy(it => it)
                    .ToArray();

                var stepsCount = orderedPositions.Any()
                    ? orderedPositions.Last() - orderedPositions.First()
                    : 0;

                Console.WriteLine(stepsCount);
            }
        }

        public class InterestingGame
        {
            public void Run()
            {
                var str = Regex.Replace(Console.ReadLine().Trim(), "[ ]{2,}", " ");
                var dimension = str.Split(" ").Select(int.Parse).ToArray();

                string winner;

                if (dimension[0] % 2 == 1 && dimension[1] % 2 == 1)
                {
                    winner = "Imp";
                }
                else
                {
                    winner = "Dragon";
                }

                Console.WriteLine(winner);
            }
        }

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

        public class Teeth
        {
            public void Run()
            {
                var input = Console.ReadLine()
                    .Trim()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                var count = input[0];
                var sharp = input[1];

                var teethSharpnessInput = Regex.Replace(Console.ReadLine().Trim(), "[ ]{2,}", " ");
                var teethSharpness = teethSharpnessInput
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                var maxCount = 0;
                var currentCount = 0;

                for (var i = 0; i < teethSharpness.Length; ++i)
                {
                    if (teethSharpness[i] >= sharp)
                    {
                        ++currentCount;
                    }
                    else
                    {
                        maxCount = Math.Max(maxCount, currentCount);
                        currentCount = 0;
                    }
                }

                maxCount = Math.Max(maxCount, currentCount);

                Console.WriteLine(maxCount);
            }
        }

        public class Helloween
        {
            public void Run()
            {
                Console.ReadLine();

                var sweetsInput1 = Regex.Replace(Console.ReadLine().Trim(), "[ ]{2,}", " ");
                var sweets1 = sweetsInput1
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                var sweetsInput2 = Regex.Replace(Console.ReadLine().Trim(), "[ ]{2,}", " ");
                var sweets2 = sweetsInput2
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                var sweets1Min = sweets1.Min();
                var sweets2Min = sweets2.Min();

                var sweetsPrice = sweets1Min + sweets2Min;

                Console.WriteLine(sweetsPrice);
            }
        }

        public class Robot
        {
            public void Run()
            {
                var commands = Console.ReadLine();

                var rightCommands = commands.Where(it => it == 'R').Count();
                var upCommands = commands.Where(it => it == 'U').Count();

                var positionInput = Console.ReadLine();
                var position = positionInput
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                var result = rightCommands >= position[0] && upCommands >= position[1]
                    ? "YES"
                    : "NO";

                Console.WriteLine(result);
            }
        }

        public class VerkhovnaRada
        {
            public void Run()
            {
                Console.ReadLine();
                var groupCount = Regex.Replace(Console.ReadLine().Trim(), "[ ]{2,}", " ")
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                var gcd = Gcd(groupCount);
                var result = groupCount.Select(it => (long)(it / gcd)).Sum();

                Console.WriteLine(result);
            }

            private static int Gcd(int a, int b)
            {
                if (a == 0)
                {
                    return b;
                }

                return Gcd(b % a, a);
            }

            private static int Gcd(int[] numbers)
            {
                return numbers.Aggregate(numbers[1], (gcd, item) => Gcd(gcd, item));
            }
        }
    }
}
