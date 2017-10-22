/**
 * @(#) Card.cs
 */

using MemoryGame.Classes;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MemoryGame.Data
{
    public abstract class Card
	{
	    public int X { get; set; }

	    public int Y { get; set; }

        public Bitmap Picture { get; set; }

	    protected readonly Stack<Command> _commands = new Stack<Command>();

	    protected Card(int x, int y, Bitmap picture)
	    {
	        X = x;
	        Y = y;
	        Picture = picture;
	    }

	    public abstract void Flip(Control control);

	    public abstract void Unflip();

	    public abstract bool Compare(Card next);
	}
}
