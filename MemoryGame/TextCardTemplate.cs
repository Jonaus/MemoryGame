/**
 * @(#) TextCardTemplate.cs
 */

using System;

namespace MemoryGame
{
	public class TextCardTemplate : TemplateMethod
	{
	    public override void AddText()
	    {
	        Console.WriteLine(@"Text Card Text");
        }

	    public override bool NeedPicture()
		{
			return true;
		}

	    public override void AddPicture()
	    {
	        Console.WriteLine(@"Text Card Picture");
        }
	}
	
}
