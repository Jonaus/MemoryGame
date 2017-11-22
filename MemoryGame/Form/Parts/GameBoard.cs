using MemoryGame.Classes;
using MemoryGame.Data;
using MemoryGame.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MemoryGame.Form.Parts
{
    class GameBoard : ControlsBuilder
    {
        private readonly int _cardCount = GameScreen.CARD_COUNT;
        private readonly string[] _playingCards = { "h", "s", "d", "c" };
        private readonly Random _rnd = new Random();
        private readonly object _syncLock = new object();

        public GameBoard()
        {
            controls = new List<Control>();
        }

        public override void BuildLabels() { }

        public override void BuildButtons()
        {
            var cf = CardFactory.CreateFactory("pc");
            var positions = new List<Tuple<int, int>>();

            for (int x = 0; x < _cardCount; x++)
            {
                for (int y = 0; y < _cardCount; y++)
                {
                    positions.Add(new Tuple<int, int>(x, y));
                }
            }

            positions = positions.OrderBy(p => _rnd.Next()).ToList();
            for (int i = 0; i < positions.Count; i += 2)
            {
                Card card = CreateRandomCard(cf, positions[i]);
                Card cardClone = card.Clone();
                cardClone.X = positions[i + 1].Item1;
                cardClone.Y = positions[i + 1].Item2;

                controls.Add(new PlayingCardButton((PlayingCard)card));
                controls.Add(new PlayingCardButton((PlayingCard)cardClone));
            }
        }

        private Card CreateRandomCard(CardFactory cf, Tuple<int, int> position)
        {
            return CreateRandomCard(cf, position.Item1, position.Item2);
        }

        private Card CreateRandomCard(CardFactory cf, int x, int y)
        {
            lock (_syncLock)
            {
                var index = _rnd.Next(0, 3);
                string playingCard = _playingCards[index];
                return cf.CreateCard(playingCard, x, y);
            }
        }
    }
}
