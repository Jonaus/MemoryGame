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
	    private readonly char[] _symbols = { '2', '3', '4', '5', '6', '7', '8', '9', 'J', 'Q', 'K', 'A' };
        private readonly Random _rnd = new Random();
        private readonly object _syncLock = new object();

        public char Symbol { get; set; }

        public PlayingCard(int x, int y, Bitmap picture) : base(x, y, picture)
        {
            Symbol = RandomSymbol();
        }

	    private char RandomSymbol()
	    {
	        lock (_syncLock)
	        {
	            var index = _rnd.Next(0, 11);
	            return _symbols[index];
            }
	    }
	}
	
}
