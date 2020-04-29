using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Algotester
{
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

            for(var i = 0; i < teethSharpness.Length; ++i)
            {
                if(teethSharpness[i] >= sharp)
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
}
