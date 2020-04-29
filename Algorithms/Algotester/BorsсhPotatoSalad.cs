using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Algotester
{
    public class BorsсhPotatoSalad
    {
        public void Run()
        {
            var friendsCount = int.Parse(Console.ReadLine());
            int A = 0, B = 0, C = 0;
            var wishes = new int[friendsCount][];

            for(var i = 0; i < friendsCount; ++i)
            { 
                var str = Regex.Replace(Console.ReadLine(), "[ ]{2,}", " ");
                var friendWish = str.Split(" ").Select(int.Parse).ToArray();
                wishes[i] = friendWish;

                A += friendWish[0];
                B += friendWish[1];
                C += friendWish[2];
            }

            var a = A / friendsCount;
            var b = B / friendsCount;
            var c = C / friendsCount;


            var complaint = 0;

            for(var i = 0; i < friendsCount; ++i)
            {
                complaint =
                    Math.Abs(wishes[i][0] - a) +
                    Math.Abs(wishes[i][1] - b) +
                    Math.Abs(wishes[i][2] - c);
            }

            Console.WriteLine(complaint);
        }
    }
}
