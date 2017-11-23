namespace MemoryGame.Form
{
    public static class FormMemory
    {
        private static Memento _memento;

        public static Memento Memento
        {
            get { return _memento; }
            set { _memento = value; }
        }
    }
}
