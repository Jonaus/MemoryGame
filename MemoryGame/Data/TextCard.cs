/**
 * @(#) TextCard.cs
 */

using System.Drawing;
using System.Windows.Forms;

namespace MemoryGame.Data
{
	public class TextCard : Card
	{
	    public TextCard(int x, int y, Bitmap picture) : base(x, y, picture)
	    {
	    }

	    public override void Flip(Control control)
	    {
	        throw new System.NotImplementedException();
	    }

	    public override void Unflip()
	    {
	        throw new System.NotImplementedException();
	    }

	    public override bool Compare(Card next)
	    {
	        throw new System.NotImplementedException();
	    }

	    public override Card Clone()
	    {
	        throw new System.NotImplementedException();
	    }
	}
	
}
