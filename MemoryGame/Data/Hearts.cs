/**
 * @(#) Hearts.cs
 */

using System.Drawing;
using MemoryGame.Properties;
using MemoryGame.Resources;

namespace MemoryGame.Data
{
	public class Hearts : PlayingCard
	{
	    public Hearts(int x, int y) : base(x, y, GetImage())
	    {
	    }

	    private static Bitmap GetImage()
	    {
	        IPlayingCardImage pci = PlayingCardImageFactory.GetImage("hearts");
	        return pci.ToBitmap();
	    }
	}
	
}
