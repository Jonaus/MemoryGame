/**
 * @(#) Clubs.cs
 */

using System.Drawing;
using MemoryGame.Properties;

namespace MemoryGame
{
	public class Clubs : PlayingCard
	{
	    private new static readonly Bitmap Picture = Resources.clubs;

        public Clubs(int x, int y) : base(x, y, Picture)
	    {
	    }
	}
	
}
