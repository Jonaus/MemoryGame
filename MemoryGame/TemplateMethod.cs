/**
 * @(#) TemplateMethod.cs
 */

using MemoryGame.Classes;
using MemoryGame.Data;

namespace MemoryGame
{
	public abstract class TemplateMethod
	{
		public Card CreateCard(string familyType, string cardType, int x, int y)
		{
		    var cf = CardFactory.CreateFactory(familyType);
		    
			AddText();
		    if (NeedPicture())
		    {
		        AddPicture();
		    }
		    return cf.CreateCard(cardType, x, y);
        }
		
		public abstract void AddText();

	    public abstract bool NeedPicture();

		public abstract void AddPicture();
		
	}
	
}
