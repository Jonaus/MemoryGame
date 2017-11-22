using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MemoryGame.UserControls;

namespace MemoryGame.Form.Parts
{
    class GameMenu : ControlsBuilder
    {
        private Button _restartButton;
        private Label _timeLabel;
        private int _menuHeight = GameScreen.MENU_HEIGHT;

        public GameMenu()
        {
            controls = new List<Control>();

            Timer clock = new Timer();
            clock.Start();
            clock.Tick += Timer_Tick;
            StopwatchControl.Start();
        }

        public override void BuildLabels()
        {
            int leftObPos = _restartButton != null ? _restartButton.Width + _restartButton.Left : 0;
            Size labelSize = new Size(85, _menuHeight);
            _timeLabel = new Label
            {
                Size = labelSize,
                Location = new Point
                {
                    X = Math.Max(GameScreen.Instance.SCREEN_WIDTH / 2 - labelSize.Width / 2 + 50, leftObPos + 50),
                    Y = _menuHeight / 2 - labelSize.Height / 2
                },
                Font = new Font(FontFamily.GenericMonospace, 18),
                TextAlign = ContentAlignment.MiddleCenter
            };
            controls.Add(_timeLabel);
            
            var _bestTimeLabel = new Label
            {
                Name = FormHelpers.BestTimeLabelName,
                Size = labelSize,
                Location = new Point
                {
                    X = GameScreen.Instance.SCREEN_WIDTH - labelSize.Width,
                    Y = _menuHeight / 2 - labelSize.Height / 2
                },
                Font = new Font(FontFamily.GenericMonospace, 18, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.DarkGreen,
                Text = "99:99"
            };
            controls.Add(_bestTimeLabel);
        }

        public override void BuildButtons()
        {
            Button prevLevel = new Button()
            {
                Size = new Size(50, _menuHeight),
                Location = new Point(5, _menuHeight / 2 - _menuHeight / 2),
                Font = new Font(FontFamily.GenericMonospace, 17, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "<"
            };
            prevLevel.Click += GameControls.PrevLevelButton_Click;
            controls.Add(prevLevel);

            Size buttonSize = new Size(150, _menuHeight);
            _restartButton = new Button
            {
                Size = buttonSize,
                Location = new Point(prevLevel.Location.X + prevLevel.Size.Width + 5, prevLevel.Location.Y),
                Font = new Font(FontFamily.GenericMonospace, 17, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "RESTART"
            };
            _restartButton.Click += GameControls.RestartButton_Click;
            controls.Add(_restartButton);

            Button nextLevel = new Button()
            {
                Size = new Size(50, _menuHeight),
                Location = new Point(_restartButton.Location.X + _restartButton.Size.Width + 5, _restartButton.Location.Y),
                Font = new Font(FontFamily.GenericMonospace, 17, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Text = ">"
            };
            nextLevel.Click += GameControls.NextLevelButton_Click;
            controls.Add(nextLevel);
        }

        private void Timer_Tick(object sender, EventArgs eArgs)
        {
            if (_timeLabel != null)
                _timeLabel.Text = StopwatchControl.Elapsed().TimespanToTimerString();
        }
    }
}
