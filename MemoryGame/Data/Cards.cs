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
        private static List<Expression> _tree = new List<Expression>
        {
            new ThousandExpression(),
            new HundredExpression(),
            new TenExpression(),
            new OneExpression()
        };

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
                        if (card1 is RomanCard && card2 is RomanCard)
                        {
                            string roman1 = card1.Text;
                            string roman2 = card2.Text;
                            Context context1 = new Context(roman1);
                            Context context2 = new Context(roman2);
                            foreach (Expression expression in _tree)
                            {
                                expression.Interpret(context1);
                                expression.Interpret(context2);
                            }
                            int num1 = context1.Output;
                            int num2 = context2.Output;

                            Console.WriteLine(@"{0}({1}) + {2}({3}) = {4}", roman1, num1, roman2, num2, num1 + num2);
                        }
                    }
                }
                catch
                {
                    // ignored
                }
            }
            if (_flippedCards.Count > MAX_FLIPPED)
            {
                for (int i = 0; i < MAX_FLIPPED; i++)
                    _flippedCards.Dequeue().Item2.Unflip();
            }
        }
    }
}
