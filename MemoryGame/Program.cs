using System;
using System.Windows.Forms;

namespace MemoryGame
{
    static class Program
    {
        public static Form.MemoryGameForm Form;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form = new Form.MemoryGameForm();
            Application.Run(Form);
        }
    }
}
