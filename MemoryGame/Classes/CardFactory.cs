/**
 * @(#) CardFactory.cs
 */

using System.Runtime.Remoting.Messaging;
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
	        if (familyType.Equals("tc"))
	        {
	            return new TextCardFactory();
	        }
	        return null;
	    }

	    public abstract Card CreateCard( string cardType, int x, int y);
	}
	
}
