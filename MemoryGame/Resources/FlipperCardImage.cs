using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame.Resources
{
    public class FlippedCardImage : IPlayingCardImage
    {
        private readonly Bitmap _bitmap;

        public FlippedCardImage()
        {
            _bitmap = new Bitmap("../../Resources/flipped_card.png");
        }

        public Bitmap ToBitmap()
        {
            return _bitmap;
        }
    }
}
