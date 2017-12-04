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
        private readonly string[] _cards = {"pc", "tc", "rc"};
        private readonly System.Random _rnd = new System.Random();
        private readonly object _syncLock = new object();
        private TemplateMethod _pcTemplate;
        private TemplateMethod _tcTemplate;

        public GameBoard()
        {
            controls = new List<Control>();
        }

        public override void BuildLabels() { }

        public override void BuildButtons()
        {
            _pcTemplate = new PlayingCardTemplate();
            _tcTemplate = new TextCardTemplate();

            var positions = new List<Tuple<int, int>>();

            for (int x = 0; x < _cardCount; x++)
            {
                for (int y = 0; y < _cardCount; y++)
                {
                    positions.Add(new Tuple<int, int>(x, y));
                }
            }

            lock (_syncLock)
            {
                positions = positions.OrderBy(p => _rnd.Next()).ToList();
            }
            for (int i = 0; i < positions.Count; i += 2)
            {
                Card card = CreateRandomCard(positions[i]);
                Card cardClone = card.CreateComparable();
                cardClone.X = positions[i + 1].Item1;
                cardClone.Y = positions[i + 1].Item2;

                controls.Add(new CardButton(card));
                controls.Add(new CardButton(cardClone));
            }
        }

        private Card CreateRandomCard(Tuple<int, int> position)
        {
            return CreateRandomCard(position.Item1, position.Item2);
        }

        private Card CreateRandomCard(int x, int y)
        {
            int index;
            lock (_syncLock)
            {
                index = _rnd.Next(0, _cards.Length);
            }
            string card = _cards[index];
            if (card == "pc")
            {
                return _pcTemplate.CreateCard(x, y);
            }
            if (card == "tc")
            {
                return _tcTemplate.CreateCard(x, y);
            }
            if (card == "rc")
            {
                return new RomanCard(x, y);
            }
            return null;
        }
    }
}
