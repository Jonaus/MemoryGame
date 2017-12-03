/**
 * @(#) PlayingCardTemplate.cs
 */

using System;
using System.Drawing;
using MemoryGame.Classes;
using MemoryGame.Data;

namespace MemoryGame
{
	public class PlayingCardTemplate : TemplateMethod
	{
	    private readonly string[] _playingCards = { "h", "s", "d", "c" };
	    private readonly System.Random _rnd = new System.Random();
        private readonly object _syncLock = new object();

        protected override Card GetCard(int x, int y)
	    {
	        var cf = CardFactory.CreateFactory("pc");
	        int index;
	        lock (_syncLock)
	        {
	            index = _rnd.Next(0, _playingCards.Length);
	        }
	        string cardType = _playingCards[index];
	        return cf.CreateCard(cardType, x, y);
	    }

	    protected override bool NeedText()
	    {
	        return false;
	    }

	    protected override string AddText()
	    {
	        return null;
	    }

	    protected override bool NeedBackground()
		{
			return false;
		}

	    protected override Color AddBackground()
	    {
	        return Color.White;
	    }
	}
	
}
