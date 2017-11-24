using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MemoryGame.Form;

namespace MemoryGame.Data
{
    public static class Cards
    {
        private const int MAX_FLIPPED = 2;
        private static Queue<Tuple<Control, Card>> _flippedCards = new Queue<Tuple<Control, Card>>();

        public static void Flip(Control ob)
        {
            if (!(ob.Tag is Card card)) return;
            _flippedCards.Enqueue(new Tuple<Control, Card>(ob, card));
            ManageFlipped();
        }

        private static void ManageFlipped()
        {
            if (_flippedCards.Count == 2)
            {
                try
                {
                    var card1 = _flippedCards.ElementAt(0).Item2;
                    var card2 = _flippedCards.ElementAt(1).Item2;
                    if (card1.Compare(card2))
                    {
                        _flippedCards.Dequeue().Item1.Dispose();
                        _flippedCards.Dequeue().Item1.Dispose();
                        (System.Windows.Forms.Form.ActiveForm as MemoryGameForm)?.CompleteObjective(card1);
                    }
                } catch { }
            }
            if (_flippedCards.Count > MAX_FLIPPED)
            {
                for (int i = 0; i < MAX_FLIPPED; i++)
                    _flippedCards.Dequeue().Item2.Unflip();
            }
        }
    }
}
