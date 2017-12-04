/**
 * @(#) TextCard.cs
 */

using System.Windows.Forms;
using MemoryGame.Classes;

namespace MemoryGame.Data
{
	public class TextCard : Card
	{
	    public TextCard(int x, int y, string text) : base(x, y, text)
	    {
	    }

	    public override void Flip(Control control)
	    {
	        // TODO: make Card extend Button/Control class and pass self as param
	        Command command = new TextCardFlipCommand(control, Text, BackgroundColor);
	        command.Execute();

	        _commands.Push(command);
        }

	    public override void Unflip()
	    {
	        if (_commands.Count > 0)
	        {
	            _commands.Pop().UnExecute();
	        }
        }

	    public override bool Compare(Card next)
	    {
	        if (!(next is TextCard nextTC)) return false;
	        if (BackgroundColor == nextTC.BackgroundColor && Text == nextTC.Text) return true;
	        return false;
        }

	    public override Card CreateComparable()
	    {
	        return (Card)this.MemberwiseClone();
        }
	}
	
}
