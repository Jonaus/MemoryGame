using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame.Data
{
    public class Random
    {
        private static readonly System.Random SystemRandom = new System.Random();
        private static readonly object SyncLock = new object();

        public static string GetLetter()
        {
            lock (SyncLock)
            {
                int num = SystemRandom.Next(0, 26);
                char let = (char)('a' + num);
                return let.ToString();
            }
        }

        public static string GetNumber()
        {
            lock (SyncLock)
            {
                int num = SystemRandom.Next(0, 9);
                return num.ToString();
            }
        }

        public static Color GetColor()
        {
            lock (SyncLock)
            {
                KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
                KnownColor randomColorName = names[SystemRandom.Next(names.Length)];
                Color randomColor = Color.FromKnownColor(randomColorName);
                return randomColor;
            }
        }
    }
}
