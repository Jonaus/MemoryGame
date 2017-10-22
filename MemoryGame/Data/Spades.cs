/**
 * @(#) Spades.cs
 */

using System.Drawing;
using MemoryGame.Properties;

namespace MemoryGame.Data
{
	public class Spades : PlayingCard
	{
	    private new static readonly Bitmap Picture = Resources.spades;

        public Spades(int x, int y) : base(x, y, Picture)
	    {
	    }
	}
	
}
