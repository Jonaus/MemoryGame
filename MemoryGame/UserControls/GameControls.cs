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

        public static void InfoButton_Click(object sender, EventArgs e)
        {
            var activeForm = System.Windows.Forms.Form.ActiveForm as MemoryGameForm;
            FormMemory.Memento = activeForm.SaveMemento();
            activeForm.Controls.Clear();
            activeForm.ConstructInfoScreen();
        }

        public static void BackButton_Click(object sender, EventArgs e)
        {
            var activeForm = System.Windows.Forms.Form.ActiveForm as MemoryGameForm;
            activeForm.Controls.Clear();
            activeForm.RestoreMemento(FormMemory.Memento);
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
