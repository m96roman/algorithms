using System.Linq;
using Algorithms;

namespace Codility.EuclideanAlgorithm
{
    public class CommonPrimeDivisors
    {
        public int solution(int[] A, int[] B)
        {
            return A.Zip(B, (a, b) => new { a, b })
                .Where(it =>
                {
                    var gcd = Gcd.Calculate(it.a, it.b);
                    return Check(it.a, gcd) && Check(it.b, gcd);
                })
                .Count();

            bool Check(int number1, int number2)
            {
                while (number1 != 1)
                {
                    var gcd = Gcd.Calculate(number1, number2);
                    if (gcd == 1)
                    {
                        break;
                    }

                    number1 /= gcd;
                }

                return number1 == 1;
            }
        }
    }
}
