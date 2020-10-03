using System;
using System.IO;
using Xunit;

namespace Algotester.Tests
{
    public class UnitTest1
    {
        public string ExecuteWithInput(Action<TextReader, TextWriter> algo, string input)
        {
            using (var reader = new StringReader(input))
            {
                using (var writer = new StringWriter())
                {
                    algo(reader, writer);
                    return writer.ToString();
                }
            }
        }

        [Theory]
        [InlineData("74", "4\r\n")]
        [InlineData("500", "1\r\n")]
        [InlineData("707", "4\r\n")]
        public void DeputyMoney(string input, string expected)
        {
            var actual = ExecuteWithInput(AlgotesterSolutions1.DeputyMoney.Run, input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("2\r\n10 50 100\r\n70 10 50", "150\r\n")]
        public void BorschPotatoSalad(string input, string expected)
        {
            var actual = ExecuteWithInput(AlgotesterSolutions1.BorschPotatoSalad.Run, input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("2\r\n4 7", "3\r\n")]
        [InlineData("7\r\n 3 1 1 2 10 7 4", "9\r\n")]
        public void ElephantsCoach(string input, string expected)
        {
            var actual = ExecuteWithInput(AlgotesterSolutions1.ElephantsCoach.Run, input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("7 4", "Dragon\r\n")]
        public void InterestingGame(string input, string expected)
        {
            var actual = ExecuteWithInput(AlgotesterSolutions1.InterestingGame.Run, input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("4\r\n4 7 47 74", "128\r\n")]
        public void MaryAndCookies(string input, string expected)
        {
            var actual = ExecuteWithInput(AlgotesterSolutions1.MaryAndCookies.Run, input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("3 5 7", "YES\r\n")]
        [InlineData("12 10 25", "NO\r\n")]
        public void Oranges(string input, string expected)
        {
            var actual = ExecuteWithInput(AlgotesterSolutions1.Oranges.Run, input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("4 7", "3.5\r\n")]
        public void PetrosCake(string input, string expected)
        {
            var actual = ExecuteWithInput(AlgotesterSolutions1.PetrosCake.Run, input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("7 4\r\n7 1 4 7 6 3 4", "3\r\n")]
        public void Teeth(string input, string expected)
        {
            var actual = ExecuteWithInput(AlgotesterSolutions1.Teeth.Run, input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("4 7\r\n4 3 2 7\r\n5 2 1 7 6 4 1", "3\r\n")]
        public void Helloween(string input, string expected)
        {
            var actual = ExecuteWithInput(AlgotesterSolutions1.Helloween.Run, input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("RURU\r\n2 0", "YES\r\n")]
        [InlineData("RRRRRR\r\n1 1", "NO\r\n")]
        public void Robot(string input, string expected)
        {
            var actual = ExecuteWithInput(AlgotesterSolutions1.Robot.Run, input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("4\r\n3108 1624 5600 2268", "450\r\n")]
        public void VerkhovnaRada(string input, string expected)
        {
            var actual = ExecuteWithInput(AlgotesterSolutions1.VerkhovnaRada.Run, input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("30\r\nVVKVKKVVVVKVKKKKKVVKKVKKKKVVVV", "1:0\r\n2:4\r\n")]
        public void KoliaVasiaTennis(string input, string expected)
        {
            var actual = ExecuteWithInput(AlgotesterSolutions1.KoliaVasiaTennis.Run, input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("2 3\r\n2 1 1\r\n1 0 0", "5\r\n1 3 1\r\n1 2 1\r\n2 1 1\r\n1 1 2\r\n1 1 1\r\n")]
        public void PotatoInBasement(string input, string expected)
        {
            var actual = ExecuteWithInput(AlgotesterSolutions1.PotatoInBasement.Run, input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("5\r\n4 7 2 10 3", "3\r\n")]
        public void LongestIncreasingSubSequence(string input, string expected)
        {
            var actual = ExecuteWithInput(AlgotesterSolutions1.LongestIncreasingSubSequence.Run, input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("3 2", "31\r\n")]
        public void NewYearMath(string input, string expected)
        {
            var actual = ExecuteWithInput(AlgotesterSolutions1.NewYearMath.Run, input);

            Assert.Equal(actual, expected);
        }
    }
}
