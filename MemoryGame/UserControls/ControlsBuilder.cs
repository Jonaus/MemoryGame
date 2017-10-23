using System.Collections.Generic;
using System.Windows.Forms;

namespace MemoryGame.UserControls
{
    abstract class ControlsBuilder
    {
        protected List<Control> controls;

        public List<Control> Controls => controls;

        public abstract void BuildLabels();
        public abstract void BuildButtons();
    }
}
