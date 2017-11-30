using System.Drawing;
using System.Windows.Forms;
using MemoryGame.Data;

namespace MemoryGame.Classes
{
    class PlayingCardFlipCommand : Command
    {
        private readonly Control _control;
        private readonly Image _oldPicture;
        private readonly Image _newPicture;
        private readonly string _oldText;
        private readonly string _newText;

        public PlayingCardFlipCommand(Control control, Image picture, string text)
        {
            _control = control;
            _oldPicture = control.BackgroundImage;
            _newPicture = picture;
            _oldText = control.Text;
            _newText = text;
        }

        public override void Execute()
        {
            Cards.Flip(_control);
            _control.BackgroundImage = _newPicture;
            _control.Text = _newText;
            _control.Enabled = false;
        }

        public override void UnExecute()
        {
            _control.BackgroundImage = _oldPicture;
            _control.Text = _oldText;
            _control.Enabled = true;
        }
    }
}
