using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MemoryGame
{
    public static class GameMenu
    {
        private static Stopwatch watch = new Stopwatch();
        private static Button restartButton;
        private static Label timeLabel;
        private static int menuWidth;
        private static int menuHeight;

        public static void DrawMenu(Form f, int width, int height)
        {
            menuWidth = width;
            menuHeight = height;
            CreateRestartButton(f);
            CreateLabel(f);

            Timer clock = new Timer();
            clock.Start();
            clock.Tick += new EventHandler(Timer_Tick);
            StartStopwatch();
        }

        private static void CreateRestartButton(Form f)
        {
            Size buttonSize = new Size(150, menuHeight);
            restartButton = new Button
            {
                Size = buttonSize,
                Location = new Point(5, menuHeight/2-buttonSize.Height/2),
                Font = new Font(FontFamily.GenericMonospace, 17, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "RESTART"
            };
            restartButton.Click += new EventHandler(GameControls.RestartButton_Click);
            f.Controls.Add(restartButton);
        }

        private static void CreateLabel(Form f)
        {
            Size labelSize = new Size(150, menuHeight);
            timeLabel = new Label
            {
                Size = labelSize,
                Location = new Point {
                    X = Math.Max(menuWidth/2-labelSize.Width/2, restartButton.Width+restartButton.Left),
                    Y = menuHeight/2-labelSize.Height/2
                },
                Font = new Font(FontFamily.GenericMonospace, 16),
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "null"
            };
            f.Controls.Add(timeLabel);
        }

        public static void StartStopwatch()
        {
            watch.Start();
        }

        public static void StopStopwatch()
        {
            watch.Stop();
        }

        public static void RestartStopwatch()
        {
            watch.Restart();
        }

        private static void Timer_Tick(object sender, EventArgs eArgs)
        {
            string elapsedSecs = watch.Elapsed.Seconds.ToString();
            string elapsedMillis = watch.Elapsed.Milliseconds.ToString();
            if (timeLabel != null) timeLabel.Text = elapsedSecs + "." + elapsedMillis;
        }
    }
}
