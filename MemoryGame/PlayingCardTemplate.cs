/**
 * @(#) PlayingCardTemplate.cs
 */

using System;
using System.Drawing;

namespace MemoryGame
{
	public class PlayingCardTemplate : TemplateMethod
	{
	    public override bool NeedText()
	    {
	        return false;
	    }

	    public override string AddText()
	    {
	        return null;
	    }

	    public override bool NeedBackground()
		{
			return false;
		}

	    public override Color AddBackground()
	    {
	        return Color.White;
	    }
	}
	
}
