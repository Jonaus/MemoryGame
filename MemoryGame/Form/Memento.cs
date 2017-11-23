using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MemoryGame.Form
{
    public class Memento
    {
        private IEnumerable<Control> _controls;

        public Memento(IEnumerable<Control> controls)
        {
            _controls = controls;
        }

        public IEnumerable<Control> Controls
        {
            get { return _controls; }
            set { _controls = value; }
        }
    }
}
