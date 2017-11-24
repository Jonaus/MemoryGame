using System.Drawing;

namespace MemoryGame.Data
{
    class AnimationRequest
    {
        private char? _cardSymbol;

        public AnimationRequest(char cardSymbol1)
        {
            this._cardSymbol = cardSymbol1;
        }

        public char? CardSymbol
        {
            get { return _cardSymbol; }
            set { _cardSymbol = value; }
        }
    }
}
