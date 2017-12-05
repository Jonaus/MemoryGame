using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame.Resources
{
    public class PlayingCardImageFactory
    {
        private static readonly Hashtable Hash = new Hashtable();

        public static IPlayingCardImage GetImage(string image)
        {
            IPlayingCardImage pci = (IPlayingCardImage) Hash[image];

            if (pci != null) return pci;
            if (image.Equals("clubs"))
            {
                pci = new ClubsImage();
            }
            if (image.Equals("diamonds"))
            {
                pci = new DiamondsImage();
            }
            if (image.Equals("hearts"))
            {
                pci = new HeartsImage();
            }
            if (image.Equals("spades"))
            {
                pci = new SpadesImage();
            }
            if (image.Equals("flipped_card"))
            {
                pci = new FlippedCardImage();
            }

            Hash.Add(image, pci);

            return pci;
        }
    }
}
