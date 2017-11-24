using System;
using System.Windows.Forms;

namespace MemoryGame.Data
{
    abstract class Animation
    {
        protected Control _object;
        protected readonly Timer _timer;
        protected Animation Successor;

        protected Animation()
        {
            InitializeObject();

            _timer = new Timer();
            _timer.Tick += Animation_Tick;
            _timer.Interval = 10;
        }

        protected void Play()
        {
            _object?.Dispose();
            InitializeObject();

            _timer.Stop();
            _timer.Start();

            System.Windows.Forms.Form.ActiveForm?.Controls.Add(_object);
        }

        public void SetSuccessor(Animation successor)
        {
            Successor = successor;
        }

        public abstract void ProcessRequest(AnimationRequest request);

        protected abstract void Animation_Tick(object sender, EventArgs e);

        protected abstract void InitializeObject();
    }
}
