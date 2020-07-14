using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class AngleBetweenHandsOfaClock
    {
        public double AngleClock(int hour, int minutes)
        {
            var minutesAngle = 6 * minutes;
            var hourAngle = 30 * (hour % 12) + 0.5 * minutes;

            var angle = Math.Abs(minutesAngle - hourAngle);
            var result = Math.Min(angle, 360 - angle);

            return result;
        }
    }
}
