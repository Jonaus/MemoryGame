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

        public static IPlayingCardImage GetImage(string imagePath)
        {
            IPlayingCardImage pci = (IPlayingCardImage) Hash[imagePath];

            if (pci != null) return pci;
            if (imagePath.Equals("../../Resources/clubs.png"))
            {
                pci = new ClubsImage(imagePath);
            }
            if (imagePath.Equals("../../Resources/diamonds.png"))
            {
                pci = new DiamondsImage(imagePath);
            }
            if (imagePath.Equals("../../Resources/hearts.png"))
            {
                pci = new HeartsImage(imagePath);
            }
            if (imagePath.Equals("../../Resources/spades.png"))
            {
                pci = new SpadesImage(imagePath);
            }
            if (imagePath.Equals("../../Resources/flipped_card.png"))
            {
                pci = new FlippedCardImage(imagePath);
            }

            Hash.Add(imagePath, pci);

            return pci;
        }
    }
}
