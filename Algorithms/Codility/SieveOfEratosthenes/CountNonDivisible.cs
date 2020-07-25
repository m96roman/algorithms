using System;
using System.Collections.Generic;
using System.Linq;

namespace Codility.SieveOfEratosthenes
{
    public class CountNonDivisible
    {
        public int[] solution(int[] A)
        {
            var numbersDict = new Dictionary<int, int>();

            var maxEl = int.MinValue;

            foreach (var el in A)
            {
                if (numbersDict.ContainsKey(el))
                {
                    numbersDict[el]++;
                }
                else
                {
                    numbersDict.Add(el, 1);
                }

                maxEl = Math.Max(maxEl, el);
            }

            var divisorsCount = A.Length;

            if (numbersDict.ContainsKey(1))
            {
                divisorsCount -= numbersDict[1];
                numbersDict.Remove(1);
            }

            var sieve = Enumerable.Repeat(divisorsCount, maxEl + 1).ToArray();

            foreach (var key in numbersDict.Keys)
            {
                var count = numbersDict[key];
                for (var i = key; i < sieve.Length; i += key)
                {
                    sieve[i] -= count;
                }
            }

            var results = new int[A.Length];

            for (var i = 0; i < A.Length; ++i)
            {
                results[i] = sieve[A[i]];
            }

            return results;
        }
    }
}
