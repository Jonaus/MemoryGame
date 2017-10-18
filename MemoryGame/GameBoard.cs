using MemoryGame.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MemoryGame
{
    class GameBoard : ControlsBuilder
    {
        private Point startPoint;
        private int cardSize;
        private int cardCount;
        private int spacingSize;

        public GameBoard(Form f, Point startPoint, int cardSize, int cardCount, int spacingSize)
        {
            controls = new List<Control>();
            this.startPoint = startPoint;
            this.cardSize = cardSize;
            this.cardCount = cardCount;
            this.spacingSize = spacingSize;
        }

        public override void BuildLabels() { }

        public override void BuildButtons()
        {
            var cf = CardFactory.CreateFactory("pc");

            for (int x = 0; x < cardCount; x++)
            {
                int xOffset = spacingSize * x;
                for (int y = 0; y < cardCount; y++)
                {
                    int yOffset = spacingSize * y;

                    Button cardButton = new Button
                    {
                        Tag = cf.CreateCard("h", x, y),
                        BackgroundImage = Resources.flipped_card,
                        BackColor = Color.White,
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Left = startPoint.X + xOffset + cardSize * x,
                        Top = startPoint.Y + yOffset + cardSize * y,
                        Width = cardSize,
                        Height = cardSize,
                        //Text = card.Symbol.ToString(),
                        ForeColor = Color.White,
                        Font = new Font("Arial", 18, FontStyle.Bold)
                    };
                    cardButton.Click += new EventHandler(GameControls.CardButton_Click);
                    controls.Add(cardButton);
                }
            }
        }
    }
}
