using System;
using System.Drawing;
using MemoryGame.Form.Parts;
using MemoryGame.UserControls;

namespace MemoryGame.Form
{
    public partial class MemoryGame : System.Windows.Forms.Form
    {
        public MemoryGame()
        {
            InitializeComponent();
            GameScreen gameScreen = GameScreen.Instance;

            ClientSize = new Size(gameScreen.SCREEN_WIDTH, gameScreen.SCREEN_HEIGHT);

            ControlsBuilder menuBuilder = new GameMenu();
            gameScreen.Construct(menuBuilder);
            Controls.AddRange(menuBuilder.Controls.ToArray());

            ControlsBuilder boardBuilder = new GameBoard();
            gameScreen.Construct(boardBuilder);
            Controls.AddRange(boardBuilder.Controls.ToArray());
        }
    }
}
