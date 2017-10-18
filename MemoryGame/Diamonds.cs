/**
 * @(#) Diamonds.cs
 */

using System.Drawing;
using MemoryGame.Properties;

namespace MemoryGame
{
	public class Diamonds : PlayingCard
	{
	    private new static readonly Bitmap Picture = Resources.diamonds;

        public Diamonds(int x, int y) : base(x, y, Picture)
	    {
	    }
	}
	
}
