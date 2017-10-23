using MemoryGame.Classes;
using MemoryGame.Data;
using MemoryGame.UserControls;
using System;
using System.Collections.Generic;
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

            for (int x = 0; x < _cardCount; x = x + 2)
            {
                for (int y = 0; y < _cardCount; y++)
                {
                    Card card = CreateRandomCard(cf, x, y);
                    Card cardClone = card.Clone();
                    cardClone.X = x + 1;
                    controls.Add(new PlayingCardButton((PlayingCard)card));
                    controls.Add(new PlayingCardButton((PlayingCard)cardClone));
                }
            }
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
