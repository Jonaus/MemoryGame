/**
 * @(#) PlayingCard.cs
 */

using System;
using System.Drawing;
using MemoryGame.Properties;

namespace MemoryGame
{
	public class PlayingCard : Card
	{
	    private static readonly char[] Symbols = { '2', '3', '4', '5', '6', '7', '8', '9', 'J', 'Q', 'K', 'A' };
        private static readonly Random Rnd = new Random();
        private static readonly object SyncLock = new object();

        public PlayingCard(int x, int y, Bitmap picture) : base(x, y, RandomSymbol(), picture)
	    {
	    }

	    private static char RandomSymbol()
	    {
	        lock (SyncLock)
	        {
	            var index = Rnd.Next(0, 11);
	            return Symbols[index];
            }
	    }
	}
	
}
