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
	    private readonly char[] _symbols = { '2', '3', '4', '5', '6', '7', '8', '9', 'J', 'Q', 'K', 'A' };
        private readonly Random _rnd = new Random();
        private readonly object _syncLock = new object();

        public char Symbol { get; set; }

        public PlayingCard(int x, int y, Bitmap picture) : base(x, y, picture)
        {
            Symbol = RandomSymbol();
        }

	    private char RandomSymbol()
	    {
	        lock (_syncLock)
	        {
	            var index = _rnd.Next(0, 11);
	            return _symbols[index];
            }
	    }

	    public override void Flip(Control control)
	    {
	        // TODO: make Card extend Button/Control class and pass self as param
	        Command command = new FlipCommand(control, Picture, Symbol.ToString());
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
	        if (Picture == nextPC.Picture && Symbol == nextPC.Symbol) return true;
	        return false;
	    }

	    public override Card Clone()
	    {
	        return (Card) this.MemberwiseClone();
	    }
	}
	
}
