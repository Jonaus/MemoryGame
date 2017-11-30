/**
 * @(#) TextCardTemplate.cs
 */

using System;
using System.Drawing;
using Random = MemoryGame.Data.Random;

namespace MemoryGame
{
	public class TextCardTemplate : TemplateMethod
	{
	    public override bool NeedText()
	    {
	        return true;
	    }

	    public override string AddText()
	    {
	        return Random.GetLetter() + Random.GetNumber();
	    }

	    public override bool NeedBackground()
		{
			return true;
		}

	    public override Color AddBackground()
	    {
	        return Random.GetColor();
	    }
	}
	
}
