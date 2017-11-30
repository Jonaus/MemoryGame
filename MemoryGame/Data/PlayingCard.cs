/**
 * @(#) PlayingCard.cs
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using MemoryGame.Classes;

namespace MemoryGame.Data
{
    public class PlayingCard : Card
	{
	    private static readonly char[] Symbols = { '2', '3', '4', '5', '6', '7', '8', '9', 'J', 'Q', 'K', 'A' };
        private static readonly System.Random Rnd = new System.Random();
        private static readonly object SyncLock = new object();

        public PlayingCard(int x, int y, Bitmap picture) : base(x, y, picture, RandomSymbol().ToString())
        {
        }

	    private static char RandomSymbol()
	    {
	        lock (SyncLock)
	        {
	            var index = Rnd.Next(0, 12);
	            return Symbols[index];
            }
	    }

	    public override void Flip(Control control)
	    {
	        // TODO: make Card extend Button/Control class and pass self as param
	        Command command = new PlayingCardFlipCommand(control, Picture, Text);
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
	        if (!(next is PlayingCard nextPC)) return false;
	        if (Picture == nextPC.Picture && Text == nextPC.Text) return true;
	        return false;
	    }
	}
	
}
