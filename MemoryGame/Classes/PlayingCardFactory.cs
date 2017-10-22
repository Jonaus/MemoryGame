/**
 * @(#) PlayingCardFactory.cs
 */

using MemoryGame.Data;

namespace MemoryGame.Classes
{
    public class PlayingCardFactory : CardFactory
    {
        public override Card CreateCard(string cardType, int x, int y)
	    {
	        if (cardType.Equals("h"))
	        {
	            return new Hearts(x, y);
	        }
	        if (cardType.Equals("s"))
	        {
	            return new Spades(x, y);
	        }
	        if (cardType.Equals("c"))
	        {
	            return new Clubs(x, y);
	        }
	        if (cardType.Equals("d"))
	        {
	            return new Diamonds(x, y);
	        }
	        return null;
	    }
	}
	
}
