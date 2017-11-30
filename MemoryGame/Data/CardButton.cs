using MemoryGame.Form.Parts;
using MemoryGame.Properties;
using System.Drawing;
using System.Windows.Forms;
using MemoryGame.Form;
using MemoryGame.UserControls;

namespace MemoryGame.Data
{
    public sealed class CardButton : Button
    {
        public CardButton(Card card)
        {
            var xOffset = GameScreen.Instance.SPACING_SIZE * card.X;
            var yOffset = GameScreen.Instance.SPACING_SIZE * card.Y;
            var startPoint = GameScreen.Instance.BOARD_STARTING_POINT;
            var cardSize = GameScreen.CARD_SIZE;

            Name = FormHelpers.CardButtonName;
            Tag = card;

            if (card is PlayingCard)
            {
                BackgroundImage = Resources.flipped_card;
                BackgroundImageLayout = ImageLayout.Stretch;
            }
            BackColor = Color.White;
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
