﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Algorithms;
using Algotester.Domain;

namespace Algotester
{
    public static class AlgotesterSolutions1
    {
        public class BorschPotatoSalad : IProblemSolver
        {
            public void Solve(TextReader reader, TextWriter writer)
            {
                var friendsCount = int.Parse(reader.ReadLine());
                int A = 0, B = 0, C = 0;
                var wishes = new int[friendsCount][];

                for (var i = 0; i < friendsCount; ++i)
                {
                    var str = Regex.Replace(reader.ReadLine(), "[ ]{2,}", " ");
                    var friendWish = str.Split(' ').Select(int.Parse).ToArray();
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

                writer.WriteLine(complaint);
            }
        }

        public class DeputyMoney : IProblemSolver
        {
            public void Solve(TextReader reader, TextWriter writer)
            {
                var input = reader.ReadLine();
                var money = int.Parse(input.Trim());

                var bills = new[] { 500, 200, 100, 50, 20, 10, 5, 2, 1 };

                var billsCount = 0;
                foreach (var bill in bills)
                {
                    while (money >= bill)
                    {
                        money -= bill;
                        billsCount += 1;
                    }
                }

                writer.WriteLine(billsCount);
            }
        }

        public class ElephantsCoach : IProblemSolver
        {
            public void Solve(TextReader reader, TextWriter writer)
            {
                reader.ReadLine();

                var postionsInput = Regex.Replace(reader.ReadLine().Trim(), "[ ]{2,}", " ");
                var positions = postionsInput
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                var orderedPositions = positions
                    .OrderBy(it => it)
                    .ToArray();

                var stepsCount = orderedPositions.Any()
                    ? orderedPositions.Last() - orderedPositions.First()
                    : 0;

                writer.WriteLine(stepsCount);
            }
        }

        public class InterestingGame : IProblemSolver
        {
            public void Solve(TextReader reader, TextWriter writer)
            {
                var str = Regex.Replace(reader.ReadLine().Trim(), "[ ]{2,}", " ");
                var dimension = str.Split(' ').Select(int.Parse).ToArray();

                string winner;

                if (dimension[0] % 2 == 1 && dimension[1] % 2 == 1)
                {
                    winner = "Imp";
                }
                else
                {
                    winner = "Dragon";
                }

                writer.WriteLine(winner);
            }
        }

        public class MaryAndCookies : IProblemSolver
        {
            public void Solve(TextReader reader, TextWriter writer)
            {
                reader.ReadLine();
                var str = Regex.Replace(reader.ReadLine(), "[ ]{2,}", " ");

                var result = str.Trim().Split()
                    .Select(it => long.Parse(it))
                    .Sum(it => it > 1 ? it - 1 : 0);

                writer.WriteLine(result);
            }
        }

        public class Oranges : IProblemSolver
        {
            public void Solve(TextReader reader, TextWriter writer)
            {
                var str = Regex.Replace(reader.ReadLine().Trim(), "[ ]{2,}", " ");
                var counts = str.Split(' ').Select(long.Parse).ToArray();

                var result = counts[0] + counts[1] > counts[2] ? "YES" : "NO";

                writer.WriteLine(result);
            }
        }

        public class PetrosCake : IProblemSolver
        {
            public void Solve(TextReader reader, TextWriter writer)
            {
                var input = reader.ReadLine()
                    .Trim()
                    .Split(' ')
                    .Select(double.Parse)
                    .ToArray();

                var count = input[0];
                var radius = input[1];

                var result = radius / Math.Sqrt(count);
                writer.WriteLine(result);
            }
        }

        public class Teeth : IProblemSolver
        {
            public void Solve(TextReader reader, TextWriter writer)
            {
                var input = reader.ReadLine()
                    .Trim()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                var count = input[0];
                var sharp = input[1];

                var teethSharpnessInput = Regex.Replace(reader.ReadLine().Trim(), "[ ]{2,}", " ");
                var teethSharpness = teethSharpnessInput
                    .Split(' ')
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

                writer.WriteLine(maxCount);
            }
        }

        public class Helloween : IProblemSolver
        {
            public void Solve(TextReader reader, TextWriter writer)
            {
                reader.ReadLine();

                var sweetsInput1 = Regex.Replace(reader.ReadLine().Trim(), "[ ]{2,}", " ");
                var sweets1 = sweetsInput1
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                var sweetsInput2 = Regex.Replace(reader.ReadLine().Trim(), "[ ]{2,}", " ");
                var sweets2 = sweetsInput2
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                var sweets1Min = sweets1.Min();
                var sweets2Min = sweets2.Min();

                var sweetsPrice = sweets1Min + sweets2Min;

                writer.WriteLine(sweetsPrice);
            }
        }

        public class Robot : IProblemSolver
        {
            public void Solve(TextReader reader, TextWriter writer)
            {
                var commands = reader.ReadLine();

                var rightCommands = commands.Where(it => it == 'R').Count();
                var upCommands = commands.Where(it => it == 'U').Count();

                var positionInput = reader.ReadLine();
                var position = positionInput
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                var result = rightCommands >= position[0] && upCommands >= position[1]
                    ? "YES"
                    : "NO";

                writer.WriteLine(result);
            }
        }

        public class VerkhovnaRada : IProblemSolver
        {
            public void Solve(TextReader reader, TextWriter writer)
            {
                reader.ReadLine();
                var groupCount = Regex.Replace(reader.ReadLine().Trim(), "[ ]{2,}", " ")
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                var gcd = Gcd.Calculate(groupCount);
                var result = groupCount.Select(it => (long)(it / gcd)).Sum();

                writer.WriteLine(result);
            }
        }

        public class KoliaVasiaTennis : IProblemSolver
        {
            public void Solve(TextReader reader, TextWriter writer)
            {
                reader.ReadLine();
                var gameStatuses = reader.ReadLine().Trim();

                var koliaCount = 0;
                var vasiaCount = 0;

                var koliaWins = 0;
                var vasiaWins = 0;

                foreach (var status in gameStatuses)
                {
                    if (status == 'K')
                    {
                        ++koliaCount;
                    }
                    else
                    {
                        ++vasiaCount;
                    }

                    if (Math.Max(koliaCount, vasiaCount) >= 11 && Math.Abs(koliaCount - vasiaCount) >= 2)
                    {
                        if (koliaCount > vasiaCount)
                        {
                            ++koliaWins;
                        }
                        else
                        {
                            ++vasiaWins;
                        }

                        koliaCount = 0;
                        vasiaCount = 0;
                    }
                }

                writer.WriteLine($"{koliaWins}:{vasiaWins}");

                if (koliaCount != 0 || vasiaCount != 0)
                {
                    writer.WriteLine($"{koliaCount}:{vasiaCount}");
                }
            }
        }

        public class PotatoInBasement : IProblemSolver
        {
            public void Solve(TextReader reader, TextWriter writer)
            {
                var dimension = reader.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

                var height = dimension[0];
                var width = dimension[1];

                var basement = new int[height][];

                for (var i = 0; i < height; ++i)
                {
                    var amounts = reader.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
                    basement[i] = amounts;
                }

                var totalAmount = basement.Sum(it => it.Sum());
                writer.WriteLine(totalAmount);

                for (var i = height - 1; i >= 0; --i)
                {
                    MoveToBottomDiagonallyAndWrite(writer, i, width - 1, height, basement);
                }

                for (var i = width - 2; i >= 0; --i)
                {
                    MoveToBottomDiagonallyAndWrite(writer, 0, i, height, basement);
                }
            }

            private static void MoveToBottomDiagonallyAndWrite(TextWriter writer, int i, int j, int height, int[][] bs)
            {
                while (j >= 0 && i < height)
                {
                    for (var l = bs[i][j]; l > 0; --l)
                    {
                        writer.WriteLine($"{i + 1} {j + 1} {l}");
                    }

                    --j;
                    ++i;
                }
            }
        }

        public class LongestIncreasingSubSequence : IProblemSolver
        {
            public void Solve(TextReader reader, TextWriter writer)
            {
                var length = int.Parse(reader.ReadLine());
                var sequence = reader.ReadLine().Split(' ').Select(int.Parse).ToArray();

                var dp = Enumerable.Repeat(1, length).ToArray();

                for (var i = length - 1; i >= 0; --i)
                {
                    for (var j = i - 1; j >= 0; --j)
                    {
                        if (sequence[i] > sequence[j])
                        {
                            dp[j] = Math.Max(dp[j], dp[i] + 1);
                        }
                    }
                }

                writer.WriteLine(dp.Max());
            }
        }

        public class NewYearMath : IProblemSolver
        {
            public void Solve(TextReader reader, TextWriter writer)
            {
                var input = reader.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                var N = input[0];
                var K = input[1];

                var maxNum = 10000000;
                var sieve = new bool[maxNum];
                sieve[0] = true;
                sieve[1] = true;

                for (var i = 2; i * i < maxNum; ++i)
                {
                    if (sieve[i])
                    {
                        continue;
                    }

                    for (var k = i * i; k < maxNum; k += i)
                    {
                        sieve[k] = true;
                    }
                }

                var primes = sieve
                    .Select((el, i) => new { value = i, isPrime = !el })
                    .Where(it => it.isPrime)
                    .Select(it => it.value)
                    .ToArray();

                var list = primes.ToList();

                for (var i = 1; i <= K; ++i)
                {
                    var currentList = new List<int>();
                    for (var j = 0; j < primes.Length && primes[j] < list.Count; ++j)
                    {
                        currentList.Add(list[primes[j] - 1]);
                    }

                    list = currentList;
                }

                var result = list[N - 1];
                writer.WriteLine(result);
            }
        }

        public class HugeTeaParty : IProblemSolver
        {
            public void Solve(TextReader reader, TextWriter writer)
            {
                var input = ReadIntArray(reader);

                var friendsCount = input[0];
                var connectionsCount = input[1];

                var friendsTea = new int[friendsCount];

                for (var i = 0; i < friendsCount; ++i)
                {
                    var friendTeaData = ReadIntArray(reader);

                    friendsTea[i] = friendTeaData[0] - friendTeaData[1];
                }

                var friendsConnection = new bool[friendsCount][];

                for (var i = 0; i < friendsConnection.Length; ++i)
                {
                    friendsConnection[i] = new bool[friendsCount];
                }

                for (var i = 0; i < connectionsCount; ++i)
                {
                    var connection = ReadIntArray(reader);

                    var friendA = connection[0] - 1;
                    var friendB = connection[1] - 1;

                    friendsConnection[friendA][friendB] = true;
                    friendsConnection[friendB][friendA] = true;
                }

                var visitedFriends = new bool[friendsCount];

                var extraTea = Enumerable
                    .Range(0, friendsCount)
                    .Sum(it => Math.Max(DFS(it, friendsConnection, visitedFriends, friendsTea), 0));

                writer.WriteLine(extraTea);
            }

            private static int DFS(int index, bool[][] connections, bool[] visited, int[] values)
            {
                if (visited[index])
                {
                    return 0;
                }

                visited[index] = true;

                return values[index] + connections[index]
                    .Select((it, i) => new { isConnected = it, idx = i })
                    .Where(it => it.isConnected)
                    .Sum(it => DFS(it.idx, connections, visited, values));
            }

            private static int[] ReadIntArray(TextReader reader)
            {
                return reader.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
            }
        }

        public class Terrorist : IProblemSolver
        {
            private class TerroristNode
            {
                public bool Visited { get; set; }

                public List<TerroristNode> Connections { get; } = new List<TerroristNode>();
            }

            public void Solve(TextReader reader, TextWriter writer)
            {
                var terroristCount = ReadIntArray(reader)[0];
                var terroristNodes = new TerroristNode[terroristCount];

                while (true)
                {
                    var connection = ReadIntArray(reader);

                    if (connection[0] == 0 && connection[1] == 0)
                    {
                        break;
                    }

                    var terroristA = connection[0] - 1;
                    var terroristB = connection[1] - 1;

                    var terroristANode = terroristNodes[terroristA]
                        = terroristNodes[terroristA] ?? new TerroristNode();
                    var terroristBNode = terroristNodes[terroristB]
                        = terroristNodes[terroristB] ?? new TerroristNode();

                    terroristANode.Connections.Add(terroristBNode);
                    terroristBNode.Connections.Add(terroristANode);
                }

                var countOfGroups = 0;

                foreach (var terroristNode in terroristNodes)
                {
                    if (terroristNode == null)
                    {
                        ++countOfGroups;
                        continue;
                    }

                    if (terroristNode.Visited)
                    {
                        continue;
                    }

                    ++countOfGroups;
                    DFS(terroristNode);
                }

                var missingConnections = countOfGroups - 1;

                writer.WriteLine(missingConnections);
            }

            private static void DFS(TerroristNode terrorist)
            {
                if (terrorist.Visited)
                {
                    return;
                }

                terrorist.Visited = true;

                foreach (var connection in terrorist.Connections)
                {
                    DFS(connection);
                }
            }

            private static int[] ReadIntArray(TextReader reader)
            {
                return reader.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
            }
        }

        public class Civilization : IProblemSolver
        {
            public void Solve(TextReader reader, TextWriter writer)
            {
                var input = ReadIntArray(reader);

                var N = input[0];
                var M = input[1];
                var K = input[2];

                var dist = new int[N][];

                for (var i = 0; i < N; ++i)
                {
                    dist[i] = Enumerable.Repeat(-1, M).ToArray();
                }

                var queue = new Queue<(int, int)>();

                for (var i = 0; i < N; ++i)
                {
                    var line = ReadIntArray(reader);

                    for (var j = 0; j < M; ++j)
                    {
                        if (line[j] == 1)
                        {
                            dist[i][j] = 0;
                            queue.Enqueue((i, j));
                        }
                    }
                }

                if (!queue.Any())
                {
                    writer.WriteLine(0);
                    return;
                }

                while (queue.Any())
                {
                    var (x, y) = queue.Dequeue();
                    var adjacentCells = GetAdjacentCells(N - 1, M - 1, x, y);

                    foreach (var (cx, cy) in adjacentCells)
                    {
                        if (dist[cx][cy] == -1)
                        {
                            dist[cx][cy] = dist[x][y] + 1;
                            queue.Enqueue((cx, cy));
                        }
                    }
                }

                var countOfInhabitedCells = dist
                    .SelectMany(it => it)
                    .Count(it => it <= K);

                writer.WriteLine(countOfInhabitedCells);
            }

            private static IEnumerable<(int, int)> GetAdjacentCells(int maxX, int maxY, int x, int y)
            {
                if (x > 0)
                {
                    yield return (x - 1, y);
                }

                if (y > 0)
                {
                    yield return (x, y - 1);
                }

                if (x < maxX)
                {
                    yield return (x + 1, y);
                }

                if (y < maxY)
                {
                    yield return (x, y + 1);
                }
            }

            private static int[] ReadIntArray(TextReader reader)
            {
                return reader.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
            }
        }

        public class DeputiesTies : IProblemSolver
        {
            public void Solve(TextReader reader, TextWriter writer)
            {
                var line1 = ReadIntArray(reader);

                var deputiesCount = line1[1];

                var ties = ReadIntArray(reader);
                var maxPossibleTieLength = ties.Select(it => (double)it).Sum() / deputiesCount;

                var result = BinarySearch(0, maxPossibleTieLength, (mid) =>
                {
                    var possibleTiesCount = ties.Sum(tie => (int)Math.Floor(tie / mid));

                    return possibleTiesCount >= deputiesCount;
                });

                writer.WriteLine($"{result:0.00000}");
            }

            private static double BinarySearch(double lowerBound, double upperBound, Predicate<double> predicate)
            {
                double lastSuccess = 0;

                while (upperBound - lowerBound >= 0.00001)
                {
                    var mid = lowerBound + (upperBound - lowerBound) / 2;

                    if (predicate(mid))
                    {
                        lastSuccess = mid;
                        lowerBound = mid;
                    }
                    else
                    {
                        upperBound = mid;
                    }
                }

                return lastSuccess;
            }

            private static int[] ReadIntArray(TextReader reader)
            {
                return reader.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
            }
        }

        public class ToiletManEscape : IProblemSolver
        {
            public void Solve(TextReader reader, TextWriter writer)
            {
                var turnsCount = ReadIntArray(reader)[0];
                var coordinates = new List<(int x, int y)>();

                for (var i = 0; i < turnsCount; ++i)
                {
                    var line = ReadIntArray(reader);
                    coordinates.Add((line[0], line[1]));
                }

                var turnRight = 0;
                var turnLeft = 0;

                for (var i = 2; i < coordinates.Count; ++i)
                {
                    var v1 = GetVector(coordinates[i - 2], coordinates[i - 1]);
                    var v2 = GetVector(coordinates[i - 2], coordinates[i]);

                    var product = GetVectorProduct(v1, v2);

                    turnLeft += product > 0 ? 1 : 0;
                    turnRight += product < 0 ? 1 : 0;
                }

                writer.WriteLine($"{turnLeft} {turnRight}");
            }

            private static int GetVectorProduct((int x, int y) v1, (int x, int y) v2)
            {
                return v1.x * v2.y - v1.y * v2.x;
            }

            private static (int x, int y) GetVector((int x, int y) p1, (int x, int y) p2)
            {
                return (p2.x - p1.x, p2.y - p1.y);
            }

            private static int[] ReadIntArray(TextReader reader)
            {
                return reader.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
            }
        }
    }
}