using MemoryGame.UserControls;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MemoryGame.Form.Parts
{
    class InfoMenu : ControlsBuilder
    {
        public InfoMenu()
        {
            controls = new List<Control>();
        }

        public override void BuildLabels()
        {
            
        }

        public override void BuildButtons()
        {
            Button backButton = new Button()
            {
                Size = new Size(100, GameScreen.MENU_HEIGHT),
                Location = new Point(GameScreen.Instance.SCREEN_WIDTH - 100 - 5, 0),
                Font = new Font(FontFamily.GenericMonospace, 17, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "BACK"
            };
            backButton.Click += GameControls.BackButton_Click;
            controls.Add(backButton);
        }
    }
}
