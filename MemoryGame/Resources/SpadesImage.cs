using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame.Resources
{
    public class SpadesImage : IPlayingCardImage
    {
        private readonly Bitmap _bitmap;

        public SpadesImage()
        {
            _bitmap = new Bitmap("../../Resources/spades.png");
        }

        public Bitmap ToBitmap()
        {
            return _bitmap;
        }
    }
}
