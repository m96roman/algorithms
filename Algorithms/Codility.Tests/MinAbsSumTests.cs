using Codility.DynamicProgramming;
using Xunit;

namespace Codility.Tests
{
    public class MinAbsSumTests
    {
        private readonly MinAbsSum _fixture;

        public MinAbsSumTests()
        {
            _fixture = new MinAbsSum();
        }

        [Theory]
        [InlineData(new[] { 1, 5, 2, -2 }, 0)]
        public void Test1(int[] input, int expected)
        {
            var actual = _fixture.solution(input);
            Assert.Equal(expected, actual);
        }
    }
}
