namespace MemoryGame
{
    class GameScreen
    {
        private static GameScreen instance;

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

        public void Construct(ControlsBuilder controlsBuilder)
        {
            controlsBuilder.BuildButtons();
            controlsBuilder.BuildLabels();
        }
    }
}
