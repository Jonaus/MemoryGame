using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame.Resources
{
    public class ClubsImage : IPlayingCardImage
    {
        private readonly Bitmap _bitmap;

        public ClubsImage(string fileName)
        {
            _bitmap = new Bitmap(fileName);
        }

        public Bitmap ToBitmap()
        {
            return _bitmap;
        }
    }
}
