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
		public Card CreateCard(string familyType, string cardType, int x, int y)
		{
		    var cf = CardFactory.CreateFactory(familyType);

		    var card = cf.CreateCard(cardType, x, y);

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

	    public abstract bool NeedText();

		public abstract string AddText();

	    public abstract bool NeedBackground();

		public abstract Color AddBackground();
		
	}
	
}
