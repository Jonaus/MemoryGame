/**
 * @(#) Card.cs
 */

using System;
using System.Drawing;

namespace MemoryGame
{
	public abstract class Card
	{
	    public int X { get; set; }

	    public int Y { get; set; }

        public char Symbol { get; set; }

        public Bitmap Picture { get; set; }

	    protected Card(int x, int y, char symbol, Bitmap picture)
	    {
	        X = x;
	        Y = y;
	        Symbol = symbol;
	        Picture = picture;
	    }
	}
}
