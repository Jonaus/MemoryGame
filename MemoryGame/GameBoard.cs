using MemoryGame.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MemoryGame
{
    public static class GameBoard
    {        
        public static void DrawBoard(Form f, Point startPoint, int size, int count, int spacingSize)
        {
            for (int x = 0; x < count; x++)
            {
                int xOffset = spacingSize * x;
                for (int y = 0; y < count; y++)
                {
                    int yOffset = spacingSize * y;

                    Button cardButton = new Button
                    {
                        BackgroundImage = Resources.ace_of_spades,
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Left = startPoint.X + xOffset + size * x,
                        Top = startPoint.Y + yOffset + size * y,
                        Width = size,
                        Height = size
                    };
                    cardButton.Click += new EventHandler(GameControls.CardButton_Click);
                    f.Controls.Add(cardButton);
                }
            }
        }
    }
}
