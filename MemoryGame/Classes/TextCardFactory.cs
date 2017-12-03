/**
 * @(#) TextCardFactory.cs
 */

using MemoryGame.Data;

namespace MemoryGame.Classes
{
	public class TextCardFactory : CardFactory
	{
	    public override Card CreateCard(string cardType, int x, int y)
	    {
	        if (cardType.Equals("l"))
	        {
	            return new Letters(x, y);
	        }
	        if (cardType.Equals("n"))
	        {
	            return new Numbers(x, y);
	        }
	        return new NullCard(x, y);
        }
	}
	
}
