using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame.Resources
{
    public class DiamondsImage : IPlayingCardImage
    {
        private readonly Bitmap _bitmap;

        public DiamondsImage()
        {
            _bitmap = new Bitmap("../../Resources/diamonds.png");
        }

        public Bitmap ToBitmap()
        {
            return _bitmap;
        }
    }
}
