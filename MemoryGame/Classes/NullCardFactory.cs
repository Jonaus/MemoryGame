using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemoryGame.Data;

namespace MemoryGame.Classes
{
    public class NullCardFactory : CardFactory
    {
        public override Card CreateCard(string cardType, int x, int y)
        {
            return new NullCard(x, y);
        }
    }
}
