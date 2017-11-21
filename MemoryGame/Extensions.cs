using System;

namespace MemoryGame
{
    public static class Extensions
    {
        public static string TimespanToTimerString(this TimeSpan timespan)
        {
            string elapsedMins = timespan.Minutes.ToString().PadLeft(2, '0');
            string elapsedSecs = timespan.Seconds.ToString().PadLeft(2, '0');
            return elapsedMins + ":" + elapsedSecs;
        }

        public static TimeSpan TimerStringToTimestamp(this string timer)
        {
            var parts = timer.Split(':');
            return new TimeSpan(0, Int32.Parse(parts[0]), Int32.Parse(parts[1]));
        }
    }
}
