using MemoryGame.Classes;
using MemoryGame.Form.Parts;
using MemoryGame.UserControls;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MemoryGame.Data;

namespace MemoryGame.Form
{
    public partial class MemoryGameForm : System.Windows.Forms.Form
    {
        public GameState State;
        private readonly Stopwatch _objectivesWatch;
        private Animation _rootAnimation;

        public MemoryGameForm()
        {
            InitializeComponent();
            
            _rootAnimation = new LowAnimation();
            var medAnimation = new MediumAnimation();
            var highAnimation = new HighAnimation();

            _rootAnimation.SetSuccessor(medAnimation);
            medAnimation.SetSuccessor(highAnimation);

            State = new GameSlowState(this);
            _objectivesWatch = new Stopwatch();
            _objectivesWatch.Start();
            ConstructGameScreen();
        }

        public void ConstructGameScreen()
        {
            GameScreen gameScreen = GameScreen.Instance;

            ClientSize = new Size(gameScreen.SCREEN_WIDTH, gameScreen.SCREEN_HEIGHT);

            ControlsBuilder menuBuilder = new GameMenu();
            gameScreen.Construct(menuBuilder);
            Controls.AddRange(menuBuilder.Controls.ToArray());

            ControlsBuilder boardBuilder = new GameBoard();
            gameScreen.Construct(boardBuilder);
            Controls.AddRange(boardBuilder.Controls.ToArray());
        }

        public void ConstructInfoScreen()
        {
            GameScreen gameScreen = GameScreen.Instance;

            ClientSize = new Size(gameScreen.SCREEN_WIDTH, gameScreen.SCREEN_HEIGHT);

            ControlsBuilder menuBuilder = new InfoMenu();
            gameScreen.Construct(menuBuilder);
            Controls.AddRange(menuBuilder.Controls.ToArray());

            ControlsBuilder boardBuilder = new InfoPanel();
            gameScreen.Construct(boardBuilder);
            Controls.AddRange(boardBuilder.Controls.ToArray());
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            BackColor = State.BackgroundColor;
        }

        public Memento SaveMemento()
        {
            var copy = new Control[Controls.Count];
            Controls.CopyTo(copy, 0);
            return new Memento(copy);
        }

        public void RestoreMemento(Memento memento)
        {
            this.Controls.Clear();
            this.Controls.AddRange(memento.Controls.ToArray());
        }

        public void CompleteObjective(Card card)
        {
            string text = card.Text;
            _rootAnimation.ProcessRequest(new AnimationRequest(text));
            State.AddTime(_objectivesWatch.Elapsed.TotalMilliseconds);
            _objectivesWatch.Restart();
        }
    }
}
