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
        public void Test1(string input, string expected)
        {
            var actual = ExecuteWithInput(AlgotesterSolutions1.DeputyMoney.Run, input);

            Assert.Equal(actual, expected);
        }
    }
}
