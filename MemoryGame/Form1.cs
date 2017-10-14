using System.Windows.Forms;

namespace MemoryGame
{
    public partial class MemoryGame : Form
    {
        public MemoryGame()
        {
            InitializeComponent();
            GameScreen gameScreen = GameScreen.Instance;
            gameScreen.DrawScreen(this);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }
    }
}
