using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MemoryGame.Classes;

namespace MemoryGame.Data
{
    public class RomanCard : Card
    {
        public RomanCard(int x, int y) : base(x, y, Random.GetRoman())
        {
            BackgroundColor = Random.GetColor();
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
            if (!(next is RomanCard nextRC)) return false;
            if (BackgroundColor == nextRC.BackgroundColor) return true;
            return false;
        }

        public override Card CreateComparable()
        {
            var comparable = (Card)this.MemberwiseClone();
            comparable.Text = Random.GetRoman();
            return comparable;
        }
    }
}
