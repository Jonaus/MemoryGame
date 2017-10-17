using System;
using System.Drawing;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class MemoryGame : Form
    {
        #region CARDS
        private static readonly int CARD_SIZE = 100;
        private static readonly int CARD_COUNT = 6;
        private static readonly int SPACING_SIZE = Convert.ToInt32(CARD_SIZE * 0.05);
        #endregion CARDS
        #region MENU
        private static readonly int MENU_MIN_WIDTH = 300;
        private static readonly int MENU_HEIGHT = 50;
        #endregion MENU
        private static readonly int SCREEN_WIDTH = CARD_SIZE * CARD_COUNT + SPACING_SIZE * (CARD_COUNT - 1);
        private static readonly int SCREEN_HEIGHT = SCREEN_WIDTH + MENU_HEIGHT;
        private static readonly Point boardStartingPoint = new Point(0, MENU_HEIGHT);

        public MemoryGame()
        {
            InitializeComponent();
            this.ClientSize = new Size(SCREEN_WIDTH, SCREEN_HEIGHT);

            GameScreen gameScreen = GameScreen.Instance;

            ControlsBuilder menuBuilder = new GameMenu(this, SCREEN_WIDTH, MENU_HEIGHT);
            gameScreen.Construct(menuBuilder);
            this.Controls.AddRange(menuBuilder.Controls.ToArray());

            ControlsBuilder boardBuilder = new GameBoard(this, boardStartingPoint, CARD_SIZE, CARD_COUNT, SPACING_SIZE);
            gameScreen.Construct(boardBuilder);
            this.Controls.AddRange(boardBuilder.Controls.ToArray());
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }
    }
}
