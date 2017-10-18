using MemoryGame.Properties;
using System;
using System.Windows.Forms;

namespace MemoryGame
{
    public static class GameControls
    {
        public static void RestartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        public static void CardButton_Click(object sender, EventArgs e)
        {
            // TODO: implement
            if (!(sender is Button cardButton)) return;
            var card = (Card)cardButton.Tag;
            cardButton.BackgroundImage = card.Picture;
            if (card is PlayingCard playingCard)
            {
                cardButton.Text = playingCard.Symbol.ToString();
            }
        }
    }
}
