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

        public string Text { get; set; }

        public Color BackgroundColor { get; set; }

	    protected readonly Stack<Command> _commands = new Stack<Command>();

	    protected Card(int x, int y, Bitmap picture, string text)
	    {
	        X = x;
	        Y = y;
	        Picture = picture;
	        Text = text;
	    }

	    protected Card(int x, int y, string text)
	    {
	        X = x;
	        Y = y;
	        Text = text;
	    }

	    public abstract void Flip(Control control);

	    public abstract void Unflip();

	    public abstract bool Compare(Card next);

	    public abstract Card CreateComparable();
	}
}
