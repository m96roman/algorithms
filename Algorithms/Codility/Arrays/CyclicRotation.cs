using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.Arrays
{
    public class CyclicRotation
    {
        public int[] solution(int[] A, int K)
        {
            var length = A.Length;

            if (length == 0 || K % length == 0)
            {
                return A;
            }

            var mod = K % length;

            var newArr = new int[length];
            for (var i = 0; i < length; ++i)
            {
                var newElId = (i + mod) % length;
                newArr[newElId] = A[i];
            }

            return newArr;
        }
    }
}
