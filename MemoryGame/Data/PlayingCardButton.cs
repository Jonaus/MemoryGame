using MemoryGame.Form.Parts;
using MemoryGame.Properties;
using System.Drawing;
using System.Windows.Forms;
using MemoryGame.UserControls;

namespace MemoryGame.Data
{
    class PlayingCardButton : Button
    {
        public PlayingCardButton(PlayingCard card)
        {
            var xOffset = GameScreen.Instance.SPACING_SIZE * card.X;
            var yOffset = GameScreen.Instance.SPACING_SIZE * card.Y;
            var startPoint = GameScreen.Instance.BOARD_STARTING_POINT;
            var cardSize = GameScreen.CARD_SIZE;

            Tag = card;
            BackgroundImage = Resources.flipped_card;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            Left = startPoint.X + xOffset + cardSize * card.X;
            Top = startPoint.Y + yOffset + cardSize * card.Y;
            Width = cardSize;
            Height = cardSize;
            //Text = card.Symbol.ToString();
            ForeColor = Color.White;
            Font = new Font("Arial", 18, FontStyle.Bold);
            Click += GameControls.CardButton_Click;
        }
    }
}
