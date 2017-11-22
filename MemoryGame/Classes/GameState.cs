using MemoryGame.Form;
using System.Collections.Generic;
using System.Drawing;

namespace MemoryGame.Classes
{
    public abstract class GameState
    {
        public MemoryGameForm GameForm;

        public Color BackgroundColor { get; protected set; }

        protected int RequiredStreak;
        protected Queue<double> Times;
        // if Sum(times) >= this, then decrease game speed state
        protected double DescendTimeLimit;
        // if Sum(times) when Count(times) == requiredStreak <= this, then increase game speed state
        protected double AscendTimeLimit;

        public abstract void AddTime(double millis);
    }
}
