using System.Collections;
using System.Linq;

namespace Codility.SieveOfEratosthenes
{
    public class CountSemiprimes
    {
        public int[] solution(int N, int[] P, int[] Q)
        {
            var sieve = new bool[N / 2 + 1];

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
                .Select((el, i) => new {value = i, isPrime = !el})
                .Where(it => it.isPrime)
                .Select(it => it.value).ToArray();

            var semiPrimes = new BitArray(N + 1);

            for (var i = 2; i < primes.Length; ++i)
            {
                for (var j = i; j < primes.Length; ++j)
                {
                    var semiPrime = primes[i] * primes[j];

                    if (semiPrime >= semiPrimes.Length)
                    {
                        break;
                    }

                    semiPrimes[semiPrime] = true;
                }
            }

            var semiPrimesPrefixSum = new int[semiPrimes.Length];
            
            for (var i = 1; i < semiPrimes.Length; ++i)
            {
                semiPrimesPrefixSum[i] += semiPrimesPrefixSum[i - 1] + (semiPrimes[i]? 1 : 0);
            }

            var result = new int[P.Length];

            for (var i = 0; i < P.Length; ++i)
            {
                result[i] = semiPrimesPrefixSum[Q[i]] - semiPrimesPrefixSum[P[i] - 1];
            }

            return result;
        }
    }
}
