using System.Collections.Generic;
using System.Windows.Forms;

namespace MemoryGame
{
    abstract class ControlsBuilder
    {
        protected List<Control> controls;

        public List<Control> Controls
        {
            get { return controls;  }
        }

        public abstract void BuildLabels();
        public abstract void BuildButtons();
    }
}
