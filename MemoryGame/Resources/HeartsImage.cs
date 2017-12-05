using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame.Resources
{
    public class HeartsImage : IPlayingCardImage
    {
        private readonly Bitmap _bitmap;

        public HeartsImage()
        {
            _bitmap = new Bitmap("../../Resources/hearts.png");
        }

        public Bitmap ToBitmap()
        {
            return _bitmap;
        }
    }
}
