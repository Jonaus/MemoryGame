using System;
using MemoryGame.UserControls;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MemoryGame.Form.Parts
{
    class InfoPanel : ControlsBuilder
    {
        public InfoPanel()
        {
            controls = new List<Control>();
        }

        public override void BuildLabels()
        {
            var infoText = new TextBox
            {
                Location = GameScreen.Instance.BOARD_STARTING_POINT,
                Size = new Size
                {
                    Height = GameScreen.Instance.SCREEN_HEIGHT,
                    Width = GameScreen.Instance.SCREEN_WIDTH
                },
                Enabled = false,
                Font = new Font(FontFamily.GenericMonospace, 18, FontStyle.Bold),
                TextAlign = HorizontalAlignment.Center,
                Multiline = true
            };
            infoText.AppendText("CREATED BY:");
            infoText.AppendText(Environment.NewLine);
            infoText.AppendText(Environment.NewLine);
            infoText.AppendText("Jonas Ausevicius");
            infoText.AppendText(Environment.NewLine);
            infoText.AppendText("Ignas Savickas");
            controls.Add(infoText);
        }

        public override void BuildButtons()
        {

        }
    }
}
