using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public static class SieveOfEratosthenes
    {
        public static int[] GetPrimesUpTo(int lastPrime)
        {
            var sieve = new bool[lastPrime + 1];

            for (var i = 2; i * i < sieve.Length; ++i)
            {
                if (sieve[i * i])
                {
                    continue;
                }

                for (var j = i * i; j < sieve.Length; j += i)
                {
                    sieve[j] = true;
                }
            }

            var primes = sieve
                .Select((el, i) => new { value = i, isPrime = !el })
                .Where(it => it.isPrime)
                .Select(it => it.value).ToArray();

            return primes;
        }
    }
}
