using MemoryGame.Form;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using MemoryGame.Form.Parts;

namespace MemoryGame.Classes
{
    class GameSlowState : GameState
    {
        public GameSlowState(GameState state) : this(state.GameForm)
        {
        }

        public GameSlowState(MemoryGameForm gameForm)
        {
            GameForm = gameForm;
            Times = new Queue<double>();
            Initialize();
        }

        private void Initialize()
        {
            BackgroundColor = Color.BlanchedAlmond;
            RequiredStreak = 5;
            DescendTimeLimit = Int32.MaxValue;
            AscendTimeLimit = GameScreen.CARD_COUNT * GameScreen.CARD_COUNT * 1000 * 1.5;
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
                GameForm.State = new GameMediumState(this);
            }
        }
    }
}
