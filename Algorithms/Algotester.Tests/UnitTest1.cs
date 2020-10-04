using System;
using System.IO;
using Xunit;

namespace Algotester.Tests
{
    public class UnitTest1
    {
        public string ExecuteWithInput(Action<TextReader, TextWriter> algo, string input)
        {
            using var reader = new StringReader(input.Replace("|nl", Environment.NewLine));
            using var writer = new StringWriter();

            algo(reader, writer);
            return writer.ToString().Replace(Environment.NewLine, "|nl");
        }

        [Theory]
        [InlineData("74", "4|nl")]
        [InlineData("500", "1|nl")]
        [InlineData("707", "4|nl")]
        public void DeputyMoney(string input, string expected)
        {
            var actual = ExecuteWithInput(AlgotesterSolutions1.DeputyMoney.Run, input);

            Assert.Equal(expected, actual);
        }

        [Theory(Skip = "Problem not solved")]
        [InlineData("2|nl10 50 100|nl70 10 50", "150|nl")]
        public void BorschPotatoSalad(string input, string expected)
        {
            var actual = ExecuteWithInput(AlgotesterSolutions1.BorschPotatoSalad.Run, input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("2|nl4 7", "3|nl")]
        [InlineData("7|nl 3 1 1 2 10 7 4", "9|nl")]
        public void ElephantsCoach(string input, string expected)
        {
            var actual = ExecuteWithInput(AlgotesterSolutions1.ElephantsCoach.Run, input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("7 4", "Dragon|nl")]
        public void InterestingGame(string input, string expected)
        {
            var actual = ExecuteWithInput(AlgotesterSolutions1.InterestingGame.Run, input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("4|nl4 7 47 74", "128|nl")]
        public void MaryAndCookies(string input, string expected)
        {
            var actual = ExecuteWithInput(AlgotesterSolutions1.MaryAndCookies.Run, input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("3 5 7", "YES|nl")]
        [InlineData("12 10 25", "NO|nl")]
        public void Oranges(string input, string expected)
        {
            var actual = ExecuteWithInput(AlgotesterSolutions1.Oranges.Run, input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("4 7", "3.5|nl")]
        public void PetrosCake(string input, string expected)
        {
            var actual = ExecuteWithInput(AlgotesterSolutions1.PetrosCake.Run, input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("7 4|nl7 1 4 7 6 3 4", "3|nl")]
        public void Teeth(string input, string expected)
        {
            var actual = ExecuteWithInput(AlgotesterSolutions1.Teeth.Run, input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("4 7|nl4 3 2 7|nl5 2 1 7 6 4 1", "3|nl")]
        public void Helloween(string input, string expected)
        {
            var actual = ExecuteWithInput(AlgotesterSolutions1.Helloween.Run, input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("RURU|nl2 0", "YES|nl")]
        [InlineData("RRRRRR|nl1 1", "NO|nl")]
        public void Robot(string input, string expected)
        {
            var actual = ExecuteWithInput(AlgotesterSolutions1.Robot.Run, input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("4|nl3108 1624 5600 2268", "450|nl")]
        public void VerkhovnaRada(string input, string expected)
        {
            var actual = ExecuteWithInput(AlgotesterSolutions1.VerkhovnaRada.Run, input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("30|nlVVKVKKVVVVKVKKKKKVVKKVKKKKVVVV", "1:0|nl2:4|nl")]
        public void KoliaVasiaTennis(string input, string expected)
        {
            var actual = ExecuteWithInput(AlgotesterSolutions1.KoliaVasiaTennis.Run, input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("2 3|nl2 1 1|nl1 0 0", "5|nl1 3 1|nl1 2 1|nl2 1 1|nl1 1 2|nl1 1 1|nl")]
        public void PotatoInBasement(string input, string expected)
        {
            var actual = ExecuteWithInput(AlgotesterSolutions1.PotatoInBasement.Run, input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("5|nl4 7 2 10 3", "3|nl")]
        public void LongestIncreasingSubSequence(string input, string expected)
        {
            var actual = ExecuteWithInput(AlgotesterSolutions1.LongestIncreasingSubSequence.Run, input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("3 2", "31|nl")]
        public void NewYearMath(string input, string expected)
        {
            var actual = ExecuteWithInput(AlgotesterSolutions1.NewYearMath.Run, input);

            Assert.Equal(actual, expected);
        }
    }
}
