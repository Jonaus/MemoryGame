using MemoryGame.Form.Parts;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MemoryGame.Data
{
    class MediumAnimation : Animation
    {
        public override void ProcessRequest(AnimationRequest request)
        {
            if (Int32.TryParse(request.CardText, out var _))
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
            _object.Size += new Size(30, 30);
            _object.Location = new Point(_object.Location.X - 15, _object.Location.Y - 15);
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
                BackColor = Color.DarkCyan
            };
        }
    }
}
