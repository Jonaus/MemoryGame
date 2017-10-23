using System;
using MemoryGame.Classes;
using MemoryGame.Properties;
using MemoryGame.UserControls;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MemoryGame.Data;

namespace MemoryGame.Form.Parts
{
    class GameBoard : ControlsBuilder
    {
        private Point _startPoint = GameScreen.Instance.BOARD_STARTING_POINT;
        private readonly int _cardSize = GameScreen.CARD_SIZE;
        private readonly int _cardCount = GameScreen.CARD_COUNT;
        private readonly int _spacingSize = GameScreen.Instance.SPACING_SIZE;
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
                int xOffset = _spacingSize * x;
                for (int y = 0; y < _cardCount; y++)
                {
                    int yOffset = _spacingSize * y;
                    Card card = CreateRandomCard(cf, x, y);
                    Card cardClone = card.Clone();
                    cardClone.X = x + 1;
                    Button cardButton = new Button
                    {
                        Tag = card,
                        BackgroundImage = Resources.flipped_card,
                        BackColor = Color.White,
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Left = _startPoint.X + xOffset + _cardSize * x,
                        Top = _startPoint.Y + yOffset + _cardSize * y,
                        Width = _cardSize,
                        Height = _cardSize,
                        //Text = card.Symbol.ToString(),
                        ForeColor = Color.White,
                        Font = new Font("Arial", 18, FontStyle.Bold)
                    };
                    cardButton.Click += GameControls.CardButton_Click;
                    controls.Add(cardButton);
                    cardButton = new Button
                    {
                        Tag = cardClone,
                        BackgroundImage = Resources.flipped_card,
                        BackColor = Color.White,
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Left = _startPoint.X + _spacingSize * (x + 1) + _cardSize * (x + 1) ,
                        Top = _startPoint.Y + yOffset + _cardSize * y,
                        Width = _cardSize,
                        Height = _cardSize,
                        //Text = card.Symbol.ToString(),
                        ForeColor = Color.White,
                        Font = new Font("Arial", 18, FontStyle.Bold)
                    };
                    cardButton.Click += GameControls.CardButton_Click;
                    controls.Add(cardButton);
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
