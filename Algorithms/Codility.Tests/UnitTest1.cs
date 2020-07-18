using Codility.DynamicProgramming;
using Codility.EuclideanAlgorithm;
using Codility.FibonacciNumbers;
using Codility.GreedyAlgorithms;
using Codility.MaximumSliceProblem;
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
        [InlineData(new int[] {  }, new int[] { }, 0)]
        public void MaxNonoverlappingSegments(int[] A, int[] B, int expected)
        {
            var algo = new MaxNonoverlappingSegments();
            var actual = algo.solution(A, B);

            Assert.Equal(expected, actual);
        }
    }
}
