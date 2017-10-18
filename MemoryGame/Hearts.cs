/**
 * @(#) Hearts.cs
 */

using System.Drawing;
using MemoryGame.Properties;

namespace MemoryGame
{
	public class Hearts : PlayingCard
	{
	    private static readonly Bitmap picture = Resources.hearts;

	    public Hearts(int x, int y) : base(x, y, picture)
	    {
	    }
	}
	
}
