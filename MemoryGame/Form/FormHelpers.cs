using MemoryGame.Form.Parts;
using MemoryGame.UserControls;
using System.Linq;
using System.Windows.Forms;

namespace MemoryGame.Form
{
    public static class FormHelpers
    {
        public const string CardButtonName = "CardButton";
        public const string BestTimeLabelName = "BestTimeLabel";

        public static void CheckIfBoardEmpty()
        {
            var controls = System.Windows.Forms.Form.ActiveForm?.Controls;
            if (controls == null) return;

            if (!controls.Find(CardButtonName, true).Any())
            {
                RestartGame();
            }
        }

        public static void RestartGame()
        {
            var controls = System.Windows.Forms.Form.ActiveForm?.Controls;
            if (controls == null) return;

            if (!controls.Find(CardButtonName, true).Any())
                SetBestTime(controls);
            else
                RemoveCardButtons(controls);

            ControlsBuilder boardBuilder = new GameBoard();
            GameScreen.Instance.Construct(boardBuilder);
            controls.AddRange(boardBuilder.Controls.ToArray());

            StopwatchControl.Restart();
        }

        private static void RemoveCardButtons(Control.ControlCollection controls)
        {
            foreach (var control in controls.Find(CardButtonName, true))
            {
                controls.Remove(control);
            }
        }

        private static void SetBestTime(Control.ControlCollection controls)
        {
            var lastBestTime = controls.Find(BestTimeLabelName, true).FirstOrDefault();
            var elapsed = StopwatchControl.Elapsed();
            if (lastBestTime != null && elapsed.CompareTo(lastBestTime.Text.TimerStringToTimestamp()) == -1)
                lastBestTime.Text = elapsed.TimespanToTimerString();
        }
    }
}
