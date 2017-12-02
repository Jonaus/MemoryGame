/**
 * @(#) Spades.cs
 */

using System.Drawing;
using MemoryGame.Properties;
using MemoryGame.Resources;

namespace MemoryGame.Data
{
	public class Spades : PlayingCard
	{
        public Spades(int x, int y) : base(x, y, GetImage())
	    {
	    }

	    private static Bitmap GetImage()
	    {
	        IPlayingCardImage pci = PlayingCardImageFactory.GetImage("../../Resources/spades.png");
	        return pci.ToBitmap();
	    }
    }
	
}
