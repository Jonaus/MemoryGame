using MemoryGame.Form;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace MemoryGame.Classes
{
    class GameMediumState : GameState
    {
        public GameMediumState(GameState state) : this(state.GameForm)
        {
        }

        public GameMediumState(MemoryGameForm gameForm)
        {
            GameForm = gameForm;
            Times = new Queue<double>();
            Initialize();
        }

        private void Initialize()
        {
            BackgroundColor = Color.BurlyWood;
            RequiredStreak = 5;
            DescendTimeLimit = 10000;
            AscendTimeLimit = 7500;
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
            if (Times.Count >= RequiredStreak && Times.Sum() <= AscendTimeLimit)
            {
                GameForm.State = new GameFastState(this);
            }
            else if (Times.Sum() >= DescendTimeLimit)
            {
                GameForm.State = new GameSlowState(this);
            }
        }
    }
}
