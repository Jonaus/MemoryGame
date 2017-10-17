using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MemoryGame
{
    class GameMenu : ControlsBuilder
    {
        private Stopwatch watch = new Stopwatch();
        private Button restartButton;
        private Label timeLabel;
        private int menuWidth;
        private int menuHeight;

        public GameMenu(Form f, int menuWidth, int menuHeight)
        {
            this.menuWidth = menuWidth;
            this.menuHeight = menuHeight;

            controls = new List<Control>();

            Timer clock = new Timer();
            clock.Start();
            clock.Tick += new EventHandler(Timer_Tick);
            StartStopwatch();
        }

        public override void BuildLabels()
        {
            int leftObPos = restartButton != null ? restartButton.Width + restartButton.Left : 0;
            Size labelSize = new Size(150, menuHeight);
            timeLabel = new Label
            {
                Size = labelSize,
                Location = new Point
                {
                    X = Math.Max(menuWidth / 2 - labelSize.Width / 2, leftObPos),
                    Y = menuHeight / 2 - labelSize.Height / 2
                },
                Font = new Font(FontFamily.GenericMonospace, 16),
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "null"
            };
            controls.Add(timeLabel);
        }

        public override void BuildButtons()
        {
            Size buttonSize = new Size(150, menuHeight);
            restartButton = new Button
            {
                Size = buttonSize,
                Location = new Point(5, menuHeight / 2 - buttonSize.Height / 2),
                Font = new Font(FontFamily.GenericMonospace, 17, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "RESTART"
            };
            restartButton.Click += new EventHandler(GameControls.RestartButton_Click);
            controls.Add(restartButton);
        }

        public void StartStopwatch()
        {
            watch.Start();
        }

        public void StopStopwatch()
        {
            watch.Stop();
        }

        public void RestartStopwatch()
        {
            watch.Restart();
        }

        private void Timer_Tick(object sender, EventArgs eArgs)
        {
            string elapsedSecs = watch.Elapsed.Seconds.ToString();
            string elapsedMillis = watch.Elapsed.Milliseconds.ToString();
            if (timeLabel != null) timeLabel.Text = elapsedSecs + "." + elapsedMillis;
        }
    }
}
