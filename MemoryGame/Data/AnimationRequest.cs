using System.Drawing;

namespace MemoryGame.Data
{
    class AnimationRequest
    {
        private string _cardText;

        public AnimationRequest(string cardText1)
        {
            this._cardText = cardText1;
        }

        public string CardText
        {
            get { return _cardText; }
            set { _cardText = value; }
        }
    }
}
