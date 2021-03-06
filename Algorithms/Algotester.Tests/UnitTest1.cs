using System;
using System.IO;
using Algotester.Domain;
using Xunit;

using static Algotester.AlgotesterSolutions1;

namespace Algotester.Tests
{
    public class UnitTest1
    {
        private static string RunProblemSolver<T>(string input) where T : IProblemSolver, new()
        {
            using var reader = new StringReader(input.Replace("|nl", Environment.NewLine));
            using var writer = new StringWriter();

            var solver = new T();
            solver.Solve(reader, writer);

            return writer.ToString().Replace(Environment.NewLine, "|nl");
        }

        private static void RunTestFor<T>(string input, string expected) where T : IProblemSolver, new()
        {
            var actual = RunProblemSolver<T>(input);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("74", "4|nl")]
        [InlineData("500", "1|nl")]
        [InlineData("707", "4|nl")]
        public void DeputyMoney(string input, string expected) =>
            RunTestFor<DeputyMoney>(input, expected);

        [Theory]
        [InlineData("2|nl10 50 100|nl70 10 50", "150|nl")]
        public void BorschPotatoSalad(string input, string expected) =>
            RunTestFor<BorschPotatoSalad>(input, expected);

        [Theory]
        [InlineData("2|nl4 7", "3|nl")]
        [InlineData("7|nl 3 1 1 2 10 7 4", "9|nl")]
        public void ElephantsCoach(string input, string expected) =>
            RunTestFor<ElephantsCoach>(input, expected);

        [Theory]
        [InlineData("7 4", "Dragon|nl")]
        public void InterestingGame(string input, string expected) =>
            RunTestFor<InterestingGame>(input, expected);

        [Theory]
        [InlineData("4|nl4 7 47 74", "128|nl")]
        public void MaryAndCookies(string input, string expected) =>
            RunTestFor<MaryAndCookies>(input, expected);

        [Theory]
        [InlineData("3 5 7", "YES|nl")]
        [InlineData("12 10 25", "NO|nl")]
        public void Oranges(string input, string expected) =>
            RunTestFor<Oranges>(input, expected);

        [Theory]
        [InlineData("4 7", "3.5|nl")]
        public void PetrosCake(string input, string expected) =>
            RunTestFor<PetrosCake>(input, expected);

        [Theory]
        [InlineData("7 4|nl7 1 4 7 6 3 4", "3|nl")]
        public void Teeth(string input, string expected) =>
            RunTestFor<Teeth>(input, expected);

        [Theory]
        [InlineData("4 7|nl4 3 2 7|nl5 2 1 7 6 4 1", "3|nl")]
        public void Helloween(string input, string expected) =>
            RunTestFor<Helloween>(input, expected);

        [Theory]
        [InlineData("RURU|nl2 0", "YES|nl")]
        [InlineData("RRRRRR|nl1 1", "NO|nl")]
        public void Robot(string input, string expected) =>
            RunTestFor<Robot>(input, expected);

        [Theory]
        [InlineData("4|nl3108 1624 5600 2268", "450|nl")]
        public void VerkhovnaRada(string input, string expected) =>
            RunTestFor<VerkhovnaRada>(input, expected);

        [Theory]
        [InlineData("30|nlVVKVKKVVVVKVKKKKKVVKKVKKKKVVVV", "1:0|nl2:4|nl")]
        public void KoliaVasiaTennis(string input, string expected) =>
            RunTestFor<KoliaVasiaTennis>(input, expected);

        [Theory]
        [InlineData("2 3|nl2 1 1|nl1 0 0", "5|nl1 3 1|nl1 2 1|nl2 1 1|nl1 1 2|nl1 1 1|nl")]
        public void PotatoInBasement(string input, string expected) =>
            RunTestFor<PotatoInBasement>(input, expected);

        [Theory]
        [InlineData("5|nl4 7 2 10 3", "3|nl")]
        public void LongestIncreasingSubSequence(string input, string expected) =>
            RunTestFor<LongestIncreasingSubSequence>(input, expected);

        [Theory]
        [InlineData("3 2", "31|nl")]
        public void NewYearMath(string input, string expected) =>
            RunTestFor<NewYearMath>(input, expected);

        [Theory]
        [InlineData("3 1|nl10 3|nl2 10|nl7 6|nl1 2", "1|nl")]
        public void HugeTeaParty(string input, string expected) =>
            RunTestFor<HugeTeaParty>(input, expected);

        [Theory]
        [InlineData("5|nl1 2|nl3 4|nl4 5|nl0 0", "1|nl")]
        [InlineData("5|nl1 2|nl3 4|nl0 0", "2|nl")]
        public void Terrorist(string input, string expected) =>
            RunTestFor<Terrorist>(input, expected);

        [Theory]
        [InlineData("3 4 1|nl0 1 0 0|nl1 0 0 0|nl0 0 0 1", "9|nl")]
        public void Civilization(string input, string expected) =>
            RunTestFor<Civilization>(input, expected);

        [Theory]
        [InlineData("3 4|nl1 10 5", "3.33333|nl")]
        public void DeputiesTies(string input, string expected) =>
            RunTestFor<DeputiesTies>(input, expected);

        [Theory]
        [InlineData("7|nl1 2|nl2 5|nl4 4|nl3 2|nl5 3|nl1 4|nl0 7|nl", "2 3|nl")]
        public void ToiletManEscape(string input, string expected) =>
            RunTestFor<ToiletManEscape>(input, expected);

        [Theory]
        [InlineData("4 3|nl1 3 2 3|nl", "4|nl")]
        [InlineData("6 4|nl1 3 2 4 3 4|nl", "8|nl")]
        [InlineData("4 5|nl1 3 2 5 3|nl", "4|nl")]
        [InlineData("6 4|nl1 3 2 3 3 4|nl", "8|nl")]
        [InlineData("3 2|nl2 2 2|nl", "0|nl")]
        [InlineData("4 1|nl2 3 5 4|nl", "0|nl")]
        [InlineData("8 4|nl2 2 3 1 4 1 4 2|nl", "26|nl")]
        public void ToiletManBegin(string input, string expected) =>
            RunTestFor<ToiletManBegin>(input, expected);

        [Theory]
        [InlineData("7|nl", "0 2|nl")]
        public void LeapYears(string input, string expected) =>
            RunTestFor<LeapYears>(input, expected);

        [Theory]
        [InlineData("3|nl4 7 5", "1 3 2|nl")]
        public void Marijuana(string input, string expected) =>
            RunTestFor<Marijuana>(input, expected);

        [Theory]
        [InlineData("15|nl7 4 4|nl", "11|nl")]
        [InlineData("41247|nl8 3 2|nl", "4|nl")]
        [InlineData("41247|nl8 3 12|nl", "16|nl")]
        [InlineData("107|nl8 3 4|nl", "8|nl")]
        [InlineData("10|nl8 3 4|nl", "11|nl")]
        [InlineData("1|nl19 3 4|nl", "7|nl")]
        [InlineData("1|nl2 3 4|nl", "2|nl")]
        [InlineData("7|nl2 3 4|nl", "0|nl")]
        [InlineData("58|nl8 3 1|nl", "5|nl")]
        public void LuckyHouse(string input, string expected) =>
            RunTestFor<LuckyHouse>(input, expected);
    }
}
