using System;
using Xunit;

namespace Algorithms.Tests
{
    public class GcdTests
    {
        [Theory]
        [InlineData(new[] { 8, 12 }, 4)]
        [InlineData(new[] { 23, 11 }, 1)]
        [InlineData(new[] { 49, 28 }, 7)]
        [InlineData(new[] { 8 }, 8)]
        public void Gcd_ValidInput_ShouldCalculateCorrectly(int[] input, int expected)
        {
            var actual = Gcd.Calculate(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Gcd_ArrayIsNull_ShouldThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => Gcd.Calculate(null));
        }

        [Fact]
        public void Gcd_EmptyArray_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Gcd.Calculate());
            Assert.Throws<ArgumentException>(() => Gcd.Calculate(new int[] { }));
        }
    }
}
