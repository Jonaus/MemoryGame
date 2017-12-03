/**
 * @(#) TextCardTemplate.cs
 */

using System;
using System.Drawing;
using MemoryGame.Classes;
using MemoryGame.Data;
using Random = MemoryGame.Data.Random;

namespace MemoryGame
{
	public class TextCardTemplate : TemplateMethod
	{
	    private readonly string[] _textCards = { "l", "n" };
        private readonly System.Random _rnd = new System.Random();
	    private readonly object _syncLock = new object();

	    protected override Card GetCard(int x, int y)
	    {
	        var cf = CardFactory.CreateFactory("tc");
	        int index;
	        lock (_syncLock)
	        {
	            index = _rnd.Next(0, _textCards.Length);
	        }
	        string cardType = _textCards[index];
	        return cf.CreateCard(cardType, x, y);
	    }

	    protected override bool NeedText()
	    {
	        return true;
	    }

	    protected override string AddText()
	    {
	        return Random.GetLetter() + Random.GetNumber();
	    }

	    protected override bool NeedBackground()
		{
			return true;
		}

	    protected override Color AddBackground()
	    {
	        return Random.GetColor();
	    }
	}
	
}
