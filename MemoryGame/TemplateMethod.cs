/**
 * @(#) TemplateMethod.cs
 */

using System.Drawing;
using MemoryGame.Classes;
using MemoryGame.Data;

namespace MemoryGame
{
	public abstract class TemplateMethod
    {
        public virtual Card CreateCard(int x, int y)
        {
            Card card = GetCard(x, y);

		    if (NeedText())
		    {
		        card.Text = card.Text + AddText();
		    }
		    if (NeedBackground())
		    {
		        card.BackgroundColor = AddBackground();
		    }
		    return card;
		}

	    protected abstract Card GetCard(int x, int y);

	    protected abstract bool NeedText();

		protected abstract string AddText();

        protected abstract bool NeedBackground();

        protected abstract Color AddBackground();
		
	}
	
}
