/**
 * @(#) Card.cs
 */

using System;

namespace MemoryGame
{
	public abstract class Card
	{
	    public int X { get; set; }

	    public int Y { get; set; }

        public char Symbol { get; set; }

	    protected Card(int x, int y, char symbol)
	    {
	        X = x;
	        Y = y;
	        Symbol = symbol;
	    }
	}
}
