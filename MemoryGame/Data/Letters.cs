/**
 * @(#) Letters.cs
 */

using System.Drawing;

namespace MemoryGame.Data
{
	public class Letters : TextCard
	{
        public Letters(int x, int y) : base(x, y, Random.GetLetter())
	    {
	    }
	}
	
}
