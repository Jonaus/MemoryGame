/**
 * @(#) CardFactory.cs
 */

using MemoryGame.Data;

namespace MemoryGame.Classes
{
	public abstract class CardFactory
	{
	    public static CardFactory CreateFactory(string familyType)
	    {
	        if (familyType.Equals("pc"))
	        {
	            return new PlayingCardFactory();
	        }
	        return null;
	    }

	    public abstract Card CreateCard( string cardType, int x, int y);
	}
	
}
