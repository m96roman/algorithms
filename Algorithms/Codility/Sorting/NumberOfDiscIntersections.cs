using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codility.Sorting
{
    public class NumberOfDiscIntersections
    {
        public int solution(int[] A)
        {
            var circlesPoints = A
                .SelectMany((it, i) =>  new[]
                {
                    new {Position = (long)i - it, IsBeginning = true},
                    new {Position = (long)i + it, IsBeginning = false}
                })
                .OrderBy(it => it.Position)
                .ThenByDescending(it => it.IsBeginning)
                .ToArray();

            var activeCircle = 0;
            var circlesInterceptions = 0;

            foreach (var point in circlesPoints)
            {
                if (point.IsBeginning)
                {
                    circlesInterceptions += activeCircle;
                    ++activeCircle;
                }
                else
                {
                    --activeCircle;
                }

                if (circlesInterceptions > 10000000)
                {
                    return -1;
                }
            }

            return circlesInterceptions;
        }
    }
}
