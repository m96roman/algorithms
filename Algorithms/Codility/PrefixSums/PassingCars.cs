using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.PrefixSums
{
    public class PassingCars
    {
        public int solution(int[] A)
        {
            var eastCars = 0;
            var passingCars = 0;

            foreach (var car in A)
            {
                if (car == 0)
                {
                    eastCars++;
                }
                else
                {
                    passingCars += eastCars;
                }

                if (passingCars > 1000000000)
                {
                    return -1;
                }
            }

            return passingCars;
        }
    }
}