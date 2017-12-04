using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame.Data
{
    public class NullCard : Card
    {
        public NullCard(int x, int y) : base(x, y, Properties.Resources._null, "null")
        {
        }

        public override void Flip(Control control)
        {
            Console.WriteLine(@"No card!");
        }

        public override void Unflip()
        {
            Console.WriteLine(@"No card!");
        }

        public override bool Compare(Card next)
        {
            return false;
        }

        public override Card CreateComparable()
        {
            return (Card)this.MemberwiseClone();
        }
    }
}
