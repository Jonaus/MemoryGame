/**
 * @(#) Diamonds.cs
 */

using System.Drawing;
using MemoryGame.Properties;

namespace MemoryGame
{
	public class Diamonds : PlayingCard
	{
	    private static readonly Bitmap picture = Resources.diamonds;

        public Diamonds(int x, int y) : base(x, y, picture)
	    {
	    }
	}
	
}
