using MemoryGame.Classes;
using MemoryGame.Form.Parts;
using MemoryGame.UserControls;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MemoryGame.Form
{
    public partial class MemoryGameForm : System.Windows.Forms.Form
    {
        public GameState State;
        private readonly Stopwatch _objectivesWatch;

        public MemoryGameForm()
        {
            InitializeComponent();

            State = new GameSlowState(this);
            _objectivesWatch = new Stopwatch();
            _objectivesWatch.Start();
            GameScreen gameScreen = GameScreen.Instance;

            ClientSize = new Size(gameScreen.SCREEN_WIDTH, gameScreen.SCREEN_HEIGHT);

            ControlsBuilder menuBuilder = new GameMenu();
            gameScreen.Construct(menuBuilder);
            Controls.AddRange(menuBuilder.Controls.ToArray());

            ControlsBuilder boardBuilder = new GameBoard();
            gameScreen.Construct(boardBuilder);
            Controls.AddRange(boardBuilder.Controls.ToArray());
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            BackColor = State.BackgroundColor;
        }

        public void CompleteObjective()
        {
            State.AddTime(_objectivesWatch.Elapsed.TotalMilliseconds);
            _objectivesWatch.Restart();
        }
    }
}
