using Codility.BinarySearchAlgorithm;
using Codility.CaterpillarMethod;
using Codility.DynamicProgramming;
using Codility.EuclideanAlgorithm;
using Codility.FibonacciNumbers;
using Codility.GreedyAlgorithms;
using Codility.IndeedPrime2015Challenge;
using Codility.IndeedPrime2016Challenge;
using Codility.IndeedPrime2016CollageChallenge;
using Codility.Iterations;
using Codility.MaximumSliceProblem;
using Codility.PrimeAndCompositeNumbers;
using Codility.SieveOfEratosthenes;
using Xunit;

namespace Codility.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new[] { 1, 5, 2, -2 }, 0)]
        public void MinAbsSum(int[] input, int expected)
        {
            var algo = new MinAbsSum();
            var actual = algo.solution(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 3, 2, 6, -1, 4, 5, -1, 2 }, 17)]
        [InlineData(new[] { 1, -4, 4, 8, 7 }, 12)]
        [InlineData(new[] { 4, 5, 3 }, 0)]
        [InlineData(new[] { -2, -4, -1, 1, -2 }, 1)]
        [InlineData(new[] { 5, 17, 0, 3 }, 17)]
        [InlineData(new[] { 5, 0, 17, 3 }, 17)]
        [InlineData(new[] { 6, 1, 5, 6, 4, 2, 9, 4 }, 26)]
        public void MaxDoubleSliceSum(int[] input, int expected)
        {
            var algo = new MaxDoubleSliceSum();
            var actual = algo.solution(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 4, 5)]
        [InlineData(10, 3, 10)]
        public void ChocolatesByNumbers(int N, int M, int expected)
        {
            var algo = new ChocolatesByNumbers();
            var actual = algo.solution(N, M);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 4, 4, 5, 5, 1 }, new[] { 3, 2, 4, 3, 1 }, new[] { 5, 1, 8, 0, 1 })]
        [InlineData(new[] { 4, 4, 5, 5, 1 }, new[] { 2, 2, 2, 2, 2 }, new[] { 1, 1, 0, 0, 1 })]
        public void Ladder(int[] A, int[] B, int[] expected)
        {
            var algo = new Ladder();
            var actual = algo.solution(A, B);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0 }, 3)]
        [InlineData(new[] { 0, 0, 0, 1, 1, 0, 0, 0 }, -1)]
        [InlineData(new[] { 0, 0, 0, 0 }, 1)]
        [InlineData(new[] { 1, 1, 1, 1, 1, 1 }, 2)]
        [InlineData(new[] { 0, 0, 0, 1, 0, 1 }, -1)]
        [InlineData(new[] { 0 }, 1)]
        [InlineData(new int[] { }, 1)]
        public void FibFrog(int[] A, int expected)
        {
            var algo = new FibFrog();
            var actual = algo.solution(A);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1, 3, 7, 9, 9 }, new[] { 5, 6, 8, 9, 10 }, 3)]
        [InlineData(new[] { 1, 3 }, new[] { 4, 8 }, 1)]
        [InlineData(new int[] { }, new int[] { }, 0)]
        public void MaxNonoverlappingSegments(int[] A, int[] B, int expected)
        {
            var algo = new MaxNonoverlappingSegments();
            var actual = algo.solution(A, B);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4, new[] { 1, 2, 3, 4, 1, 1, 3 }, 3)]
        public void TieRopes(int K, int[] A, int expected)
        {
            var algo = new TieRopes();
            var actual = algo.solution(K, A);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1, 4, 5, 8 }, new[] { 4, 5, 9, 10 }, new[] { 4, 6, 7, 10, 2 }, 4)]
        [InlineData(new[] { 1, 4, 7 }, new[] { 3, 6, 9 }, new[] { 2, 5, 8, 10, 10 }, 3)]
        [InlineData(new[] { 1, 4, 7 }, new[] { 3, 6, 9 }, new[] { 0, 5, 8, 10, 10 }, -1)]
        [InlineData(new[] { 1, 3 }, new[] { 3, 4 }, new[] { 3, 2, 4 }, 1)]
        public void NailingPlanks(int[] A, int[] B, int[] C, int expected)
        {
            var algo = new NailingPlanks();
            var actual = algo.solution(A, B, C);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3, 5, new[] { 2, 1, 5, 1, 2, 2, 2 }, 6)]
        [InlineData(3, 5, new[] { 3, 3, 3, 3, 3, 3, 3, 3, 3 }, 9)]
        [InlineData(2, 5, new[] { 3, 2, 4 }, 5)]
        public void MinMaxDivision(int K, int M, int[] A, int expected)
        {
            var algo = new MinMaxDivision();
            var actual = algo.solution(K, M, A);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 3, 1, 2, 3, 6 }, new[] { 2, 4, 3, 2, 0 })]
        public void CountNonDivisible(int[] A, int[] expected)
        {
            var algo = new CountNonDivisible();
            var actual = algo.solution(A);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1, 5, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2 }, 3)]
        [InlineData(new[] { 1, 3, 1, 1, 1, 3, 1, 1, 1, 3, 1, 1, 1, 3, 1 }, 4)]
        public void Flags(int[] input, int expected)
        {
            var algo = new Flags();
            var actual = algo.solution(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2 }, 3)]
        [InlineData(new[] { 5 }, 0)]
        [InlineData(new[] { 1, 3, 2, 1 }, 1)]
        public void Peaks(int[] input, int expected)
        {
            var algo = new Peaks();
            var actual = algo.solution(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(26, new[] { 1, 4, 16 }, new[] { 26, 10, 20 }, new[] { 10, 4, 0 })]
        public void CountSemiprimes(int N, int[] P, int[] Q, int[] expected)
        {
            var algo = new CountSemiprimes();
            var actual = algo.solution(N, P, Q);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 15, 10, 3 }, new[] { 75, 30, 5 }, 1)]
        public void CommonPrimeDivisors(int[] A, int[] B, int expected)
        {
            var algo = new CommonPrimeDivisors();
            var actual = algo.solution(A, B);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("test 5 a0A pass007 ?xy1", 7)]
        [InlineData("test ?xy1", -1)]
        public void LongestPassword(string S, int expected)
        {
            var algo = new LongestPassword();
            var actual = algo.solution(S);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1, 3, 2, 1, 2, 1, 5, 3, 3, 4, 2 }, 2)]
        [InlineData(new[] { 5, 8 }, 0)]
        [InlineData(new[] { 9, 7, 2, 7, 9 }, 7)]
        public void FloodDepth(int[] A, int expected)
        {
            var algo = new FloodDepth();
            var actual = algo.solution(A);
            var actual2 = algo.solution2(A);

            Assert.Equal(expected, actual);
            Assert.Equal(expected, actual2);
        }

        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(10, 3, 3)]
        public void TennisTournament(int P, int C, int expected)
        {
            var algo = new TennisTournament();
            var actual = algo.solution(P, C);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, new[] { 1, 2, 1, 1 }, new[] { 1, 4, 3, 2, 4 }, 3)]
        [InlineData(2, new[] { 1, 1, 1, 1 }, new[] { 5, 5 }, 3)]
        public void SocksLaundering(int K, int[] C, int[] D, int expected)
        {
            var algo = new SocksLaundering();
            var actual = algo.solution(K, C, D);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 5, 1, 1, 2, 3, 5, 1 }, 5, 2)]
        [InlineData(new[] { 2, 3, 2, 3, 2, 3, 2, 3 }, 9, 1)]
        public void RectangleBuilderGreaterArea(int[] A, int X, int expected)
        {
            var algo = new RectangleBuilderGreaterArea();
            var actual = algo.solution(A, X);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new[] { -5, -3, -1, 0, 3, 6 }, 5)]
        [InlineData(new[] { -5, -5, -1, 0, 1, 1, 1, 1, 4, 5, 6, 6, 6 }, 5)]
        public void AbsDistinct(int[] A, int expected)
        {
            var algo = new AbsDistinct();
            var actual = algo.solution(A);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(9, 2)]
        [InlineData(529, 4)]
        [InlineData(20, 1)]
        [InlineData(15, 0)]
        [InlineData(32, 0)]
        [InlineData(1041, 5)]
        public void BinaryGap(int n, int expected)
        {
            var algo = new BinaryGap();
            var actual = algo.solution(n);

            Assert.Equal(expected, actual);
        }
    }
}
