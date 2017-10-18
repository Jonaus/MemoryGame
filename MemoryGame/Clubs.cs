/**
 * @(#) Clubs.cs
 */

using System.Drawing;
using MemoryGame.Properties;

namespace MemoryGame
{
	public class Clubs : PlayingCard
	{
	    private static readonly Bitmap picture = Resources.clubs;

        public Clubs(int x, int y) : base(x, y, picture)
	    {
	    }
	}
	
}
