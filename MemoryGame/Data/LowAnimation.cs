using MemoryGame.Form.Parts;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MemoryGame.Data
{
    class LowAnimation : Animation
    {
        public override void ProcessRequest(AnimationRequest request)
        {
            if (Int32.TryParse(request.CardSymbol.ToString(), out var num) && num < 6)
            {
                Play();
            }
            else
            {   
                Successor?.ProcessRequest(request);
            }
        }

        protected override void Animation_Tick(object sender, EventArgs e)
        {
            _object.Size += new Size(50, 50);
            _object.Location = new Point(_object.Location.X - 25, _object.Location.Y - 25);
            if (_object.Size.Width > GameScreen.Instance.SCREEN_WIDTH * 1.5)
            {
                _timer.Stop();
                _object.Dispose();
            }
        }

        protected override void InitializeObject()
        {
            _object = new Control
            {
                Location = new Point(GameScreen.Instance.SCREEN_WIDTH / 2, GameScreen.Instance.SCREEN_HEIGHT / 2),
                Size = new Size(1, 1),
                BackColor = Color.Aquamarine
            };
        }
    }
}
