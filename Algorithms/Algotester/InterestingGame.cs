using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Algotester
{
    public class InterestingGame
    {
        public void Run()
        {
            var str = Regex.Replace(Console.ReadLine().Trim(), "[ ]{2,}", " ");
            var dimension = str.Split(" ").Select(int.Parse).ToArray();

            string winner;

            if(dimension[0] % 2 == 1 && dimension[1] % 2 == 1)
            {
                winner = "Imp";
            }
            else
            {
                winner = "Dragon";
            }

            Console.WriteLine(winner);
        }
    }
}
