using MemoryGame.Data;
using System;
using System.Windows.Forms;
using MemoryGame.Form;

namespace MemoryGame.UserControls
{
    public static class GameControls
    {
        public static void PrevLevelButton_Click(object sender, EventArgs e)
        {
            
        }

        public static void RestartButton_Click(object sender, EventArgs e)
        {
            FormHelpers.RestartGame();
        }

        public static void NextLevelButton_Click(object sender, EventArgs e)
        {

        }

        public static void CardButton_Click(object sender, EventArgs e)
        {
            try
            {
                Button cardButton = (Button) sender;
                Card card = (Card) cardButton.Tag;
                card.Flip(cardButton);
                FormHelpers.CheckIfBoardEmpty();
            }
            catch
            {
                // ignored
            }
        }
    }
}
