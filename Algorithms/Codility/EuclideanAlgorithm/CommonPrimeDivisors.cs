using System.Linq;
using Algorithms;

namespace Codility.EuclideanAlgorithm
{
    public class CommonPrimeDivisors
    {
        public int solution(int[] A, int[] B)
        {
            return A
                .Zip(B, (a, b) => new { a, b })
                .Count(it => Check(it.a, it.b) && Check(it.b, it.a));

            bool Check(int number1, int number2)
            {
                var gcd = -1;

                while (gcd != 1)
                {
                    gcd = Gcd.Calculate(number1, number2);
                    number1 /= gcd;
                }

                return number1 == 1;
            }
        }
    }
}
