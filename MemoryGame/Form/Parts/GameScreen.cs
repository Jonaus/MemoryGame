using System;
using System.Drawing;
using MemoryGame.UserControls;

namespace MemoryGame.Form.Parts
{
    class GameScreen
    {
        #region CARDS
        public const int CARD_SIZE = 100;
        public const int CARD_COUNT = 6;
        public readonly int SPACING_SIZE;
        #endregion CARDS
        #region MENU
        public const int MENU_MIN_WIDTH = 300;
        public const int MENU_HEIGHT = 50;
        #endregion MENU
        public readonly int SCREEN_WIDTH;
        public readonly int SCREEN_HEIGHT;
        public readonly Point BOARD_STARTING_POINT = new Point(0, MENU_HEIGHT);

        private static GameScreen instance;

        private GameScreen()
        {
            SPACING_SIZE = Convert.ToInt32(CARD_SIZE * 0.05);
            SCREEN_WIDTH = CARD_SIZE * CARD_COUNT + SPACING_SIZE * (CARD_COUNT - 1);
            SCREEN_HEIGHT = SCREEN_WIDTH + MENU_HEIGHT;
        }

        public static GameScreen Instance => instance ?? (instance = new GameScreen());

        public void Construct(ControlsBuilder controlsBuilder)
        {
            controlsBuilder.BuildButtons();
            controlsBuilder.BuildLabels();
        }
    }
}
