using MemoryGame.Data;
using System;
using System.Windows.Forms;

namespace MemoryGame.UserControls
{
    public static class GameControls
    {
        public static void PrevLevelButton_Click(object sender, EventArgs e)
        {
            
        }

        public static void RestartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
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
            }
            catch
            {
                // ignored
            }
        }
    }
}
