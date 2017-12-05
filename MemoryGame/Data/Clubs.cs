/**
 * @(#) Clubs.cs
 */

using System.Drawing;
using MemoryGame.Properties;
using MemoryGame.Resources;

namespace MemoryGame.Data
{
	public class Clubs : PlayingCard
	{
        public Clubs(int x, int y) : base(x, y, GetImage())
	    {
	    }

	    private static Bitmap GetImage()
	    {
	        IPlayingCardImage pci = PlayingCardImageFactory.GetImage("clubs");
	        return pci.ToBitmap();
	    }
    }
	
}
