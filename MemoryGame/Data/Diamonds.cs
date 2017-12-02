/**
 * @(#) Diamonds.cs
 */

using System.Drawing;
using MemoryGame.Properties;
using MemoryGame.Resources;

namespace MemoryGame.Data
{
	public class Diamonds : PlayingCard
	{
        public Diamonds(int x, int y) : base(x, y, GetImage())
	    {
	    }

	    private static Bitmap GetImage()
	    {
	        IPlayingCardImage pci = PlayingCardImageFactory.GetImage("../../Resources/diamonds.png");
	        return pci.ToBitmap();
	    }
    }
	
}
