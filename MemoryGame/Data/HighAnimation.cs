using MemoryGame.Form.Parts;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MemoryGame.Data
{
    class HighAnimation : Animation
    {
        public override void ProcessRequest(AnimationRequest request)
        {
            if (request.CardText != null)
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
            _object.Size += new Size(20, 20);
            _object.Location = new Point(_object.Location.X - 10, _object.Location.Y - 10);
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
                BackColor = Color.Crimson
            };
        }
    }
}
