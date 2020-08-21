using System;
using System.Collections.Generic;
using System.Text;

namespace Codility.IndeedPrime2016CollageChallenge
{
    public class SocksLaundering
    {
        public int solution(int K, int[] C, int[] D)
        {
            var clean = new int[51];
            var dirty = new int[51];
            
            foreach (var c in C)
            {
                clean[c] += 1;
            }

            foreach (var d in D)
            {
                dirty[d] += 1;
            }

            var pairs = 0;
            var canWash = K;

            for (var i = 0; i < clean.Length; ++i)
            {
                if (clean[i] % 2 == 1 && dirty[i] > 0 && canWash > 0)
                {
                    --dirty[i];
                    --canWash;
                    ++clean[i];
                }

                pairs += clean[i] / 2;
            }

            var canWashPairs = canWash / 2;

            for (var i = 0; i < dirty.Length && canWashPairs > 0; ++i)
            {
                var additionalPairs = dirty[i] / 2;
                var pairsToWash = Math.Min(additionalPairs, canWashPairs);

                pairs += pairsToWash;
                canWashPairs -= pairsToWash;
            }

            return pairs;
        }
    }
}
