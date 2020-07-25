namespace LeetCode
{
    public class WaterBottles
    {
        public int NumWaterBottles(int numBottles, int numExchange)
        {
            var sumOfBottles = numBottles;

            while (numBottles / numExchange > 0)
            {
                var newBottles = numBottles / numExchange;

                numBottles = numBottles % numExchange + newBottles;
                sumOfBottles += newBottles;
            }

            return sumOfBottles;
        }
    }
}
