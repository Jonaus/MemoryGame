using System.Drawing;
using System.Windows.Forms;
using MemoryGame.Data;

namespace MemoryGame.Classes
{
    class TextCardFlipCommand : Command
    {
        private readonly Control _control;
        private readonly string _oldText;
        private readonly string _newText;
        private readonly Color _oldColor;
        private readonly Color _newColor;

        public TextCardFlipCommand(Control control, string text, Color backgroundColor)
        {
            _control = control;
            _oldText = control.Text;
            _newText = text;
            _oldColor = control.BackColor;
            _newColor = backgroundColor;
        }

        public override void Execute()
        {
            Cards.Flip(_control);
            _control.Text = _newText;
            _control.BackColor = _newColor;
            _control.Enabled = false;
        }

        public override void UnExecute()
        {
            _control.Text = _oldText;
            _control.BackColor = _oldColor;
            _control.Enabled = true;
        }
    }
}
