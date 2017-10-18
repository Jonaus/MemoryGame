/**
 * @(#) Hearts.cs
 */

using System.Drawing;
using MemoryGame.Properties;

namespace MemoryGame
{
	public class Hearts : PlayingCard
	{
	    private new static readonly Bitmap Picture = Resources.hearts;

	    public Hearts(int x, int y) : base(x, y, Picture)
	    {
	    }
	}
	
}
