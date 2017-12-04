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
                if (randomColor.R < 100 && randomColor.G < 100 && randomColor.B < 100 || randomColor.R > 200 && randomColor.G > 200 && randomColor.B > 200)
                {
                    return GetColor();
                }
                return randomColor;
            }
        }

        public static string GetRoman()
        {
            lock (SyncLock)
            {
                int num = SystemRandom.Next(1, 4000);
                return ToRoman(num);
            }
        }

        private static string ToRoman(int number)
        {
            if (number < 0 || number > 3999) throw new ArgumentOutOfRangeException("Value must be between 1 and 3999");
            if (number < 1) return string.Empty;
            if (number >= 1000) return "M" + ToRoman(number - 1000);
            if (number >= 900) return "CM" + ToRoman(number - 900); //EDIT: i've typed 400 instead 900
            if (number >= 500) return "D" + ToRoman(number - 500);
            if (number >= 400) return "CD" + ToRoman(number - 400);
            if (number >= 100) return "C" + ToRoman(number - 100);
            if (number >= 90) return "XC" + ToRoman(number - 90);
            if (number >= 50) return "L" + ToRoman(number - 50);
            if (number >= 40) return "XL" + ToRoman(number - 40);
            if (number >= 10) return "X" + ToRoman(number - 10);
            if (number >= 9) return "IX" + ToRoman(number - 9);
            if (number >= 5) return "V" + ToRoman(number - 5);
            if (number >= 4) return "IV" + ToRoman(number - 4);
            if (number >= 1) return "I" + ToRoman(number - 1);
            throw new ArgumentOutOfRangeException("Value must be between 1 and 3999");
        }
    }
}
