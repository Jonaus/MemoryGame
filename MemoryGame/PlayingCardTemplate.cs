/**
 * @(#) PlayingCardTemplate.cs
 */

using System;

namespace MemoryGame
{
	public class PlayingCardTemplate : TemplateMethod
	{
	    public override void AddText()
	    {
	        Console.WriteLine(@"Playing Card Text");
	    }

	    public override bool NeedPicture()
		{
			return false;
		}

	    public override void AddPicture()
	    {
	        Console.WriteLine(@"Playing Card Picture");
	    }
	}
	
}
