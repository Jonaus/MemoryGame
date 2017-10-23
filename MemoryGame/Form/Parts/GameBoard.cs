using MemoryGame.Classes;
using MemoryGame.Properties;
using MemoryGame.UserControls;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MemoryGame.Form.Parts
{
    class GameBoard : ControlsBuilder
    {
        private Point _startPoint = GameScreen.Instance.BOARD_STARTING_POINT;
        private readonly int _cardSize = GameScreen.CARD_SIZE;
        private readonly int _cardCount = GameScreen.CARD_COUNT;
        private readonly int _spacingSize = GameScreen.Instance.SPACING_SIZE;

        public GameBoard()
        {
            controls = new List<Control>();
        }

        public override void BuildLabels() { }

        public override void BuildButtons()
        {
            var cf = CardFactory.CreateFactory("pc");

            for (int x = 0; x < _cardCount; x++)
            {
                int xOffset = _spacingSize * x;
                for (int y = 0; y < _cardCount; y++)
                {
                    int yOffset = _spacingSize * y;

                    Button cardButton = new Button
                    {
                        Tag = cf.CreateCard("h", x, y),
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
                }
            }
        }

        public override ControlsBuilder Clone()
        {
            return (ControlsBuilder) this.MemberwiseClone();
        }
    }
}
