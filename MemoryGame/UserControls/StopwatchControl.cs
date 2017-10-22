using System;
using System.Diagnostics;

namespace MemoryGame.UserControls
{
    public static class StopwatchControl
    {
        private static readonly Stopwatch Watch = new Stopwatch();

        public static TimeSpan Elapsed()
        {
            return Watch.Elapsed;
        }

        public static void Start()
        {
            Watch.Start();
        }

        public static void Stop()
        {
            Watch.Stop();
        }

        public static void Restart()
        {
            Watch.Restart();
        }
    }
}
