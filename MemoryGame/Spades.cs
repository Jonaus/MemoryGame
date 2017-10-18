/**
 * @(#) Spades.cs
 */

using System.Drawing;
using MemoryGame.Properties;

namespace MemoryGame
{
	public class Spades : PlayingCard
	{
	    private static readonly Bitmap picture = Resources.spades;

        public Spades(int x, int y) : base(x, y, picture)
	    {
	    }
	}
	
}
