using MemoryGame.Form;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using MemoryGame.Form.Parts;

namespace MemoryGame.Classes
{
    class GameFastState : GameState
    {
        public GameFastState(GameState state) : this(state.GameForm)
        {
        }

        public GameFastState(MemoryGameForm gameForm)
        {
            GameForm = gameForm;
            Times = new Queue<double>();
            Initialize();
        }

        private void Initialize()
        {
            BackgroundColor = Color.Chocolate;
            RequiredStreak = 5;
            DescendTimeLimit = GameScreen.CARD_COUNT * GameScreen.CARD_COUNT * 1000 * 1;
        }

        public override void AddTime(double millis)
        {
            while (Times.Count >= RequiredStreak)
                Times.Dequeue();
            Times.Enqueue(millis);

            StateChangeCheck();
        }

        private void StateChangeCheck()
        {
            if (Times.Sum() >= DescendTimeLimit)
            {
                GameForm.State = new GameMediumState(this);
            }
        }
    }
}
