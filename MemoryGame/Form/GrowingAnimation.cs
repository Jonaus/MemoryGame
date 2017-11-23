using MemoryGame.Form.Parts;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MemoryGame.Form
{
    public static class GrowingAnimation
    {
        private static Control _rect;
        private static readonly Timer Timer;

        static GrowingAnimation()
        {
            InitializeRect();

            Timer = new Timer();
            Timer.Tick += Animation_Tick;
            Timer.Interval = 10;
        }

        private static void InitializeRect()
        {
            _rect = new Control
            {
                Location = new Point(GameScreen.Instance.SCREEN_WIDTH / 2, GameScreen.Instance.SCREEN_HEIGHT / 2),
                Size = new Size(1, 1),
                BackColor = Color.BlueViolet
            };
        }

        public static void Play()
        {
            _rect?.Dispose();
            InitializeRect();

            Timer.Stop();
            Timer.Start();

            System.Windows.Forms.Form.ActiveForm?.Controls.Add(_rect);
        }

        private static void Animation_Tick(object sender, EventArgs e)
        {
            _rect.Size += new Size(30, 30);
            _rect.Location = new Point(_rect.Location.X - 15, _rect.Location.Y - 15);
            if (_rect.Size.Width > GameScreen.Instance.SCREEN_WIDTH)
            {
                Timer.Stop();
                _rect.Dispose();
            }
        }
    }
}
