using System;
using System.Drawing;
using System.Windows.Forms;

namespace MemoryGame
{
    public class GameScreen
    {
        private static GameScreen instance;

        #region CARDS
        private static readonly int CARD_SIZE = 100;
        private static readonly int CARD_COUNT = 6;
        private static readonly int SPACING_SIZE = Convert.ToInt32(CARD_SIZE * 0.05);
        #endregion CARDS
        #region MENU
        private static readonly int MENU_MIN_WIDTH = 300;
        private static readonly int MENU_HEIGHT = 50;
        #endregion MENU
        private static readonly int SCREEN_WIDTH = CARD_SIZE * CARD_COUNT + SPACING_SIZE * (CARD_COUNT-1);
        private static readonly int SCREEN_HEIGHT = SCREEN_WIDTH + MENU_HEIGHT;
        private static readonly Point boardStartingPoint = new Point(0, MENU_HEIGHT);

        private GameScreen() { }

        public static GameScreen Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameScreen();
                }
                return instance;
            }
        }

        public void DrawScreen(Form f)
        {   
            f.ClientSize = new Size(SCREEN_WIDTH, SCREEN_HEIGHT);
            GameMenu.DrawMenu(f, SCREEN_WIDTH, MENU_HEIGHT);
            GameBoard.DrawBoard(f, boardStartingPoint, CARD_SIZE, CARD_COUNT, SPACING_SIZE);
        }
    }
}
