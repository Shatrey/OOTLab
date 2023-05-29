namespace Lab7
{
    internal class EditorMemento
    {
        private string content;

        public EditorMemento(string content)
        {
            this.content = content;
        }

        public string GetContent()
        {
            return content;
        }
    }

    internal class Caretaker
    {
        private List<EditorMemento> _mementos = new List<EditorMemento>();

        private Editor _editor = null;

        public Caretaker(Editor editor)
        {
            _editor = editor;
        }

        public void Backup()
        {
            Console.WriteLine("Create backup");
            _mementos.Add(_editor.Save());
        }

        public void Undo()
        {
            if (_mementos.Count == 0)
            {
                return;
            }

            var memento = _mementos.Last();
            _mementos.Remove(memento);

            Console.WriteLine($"Restore state to {memento.GetContent()}");

             _editor.Restore(memento);
        }

        public void ShowHistory()
        {
            Console.WriteLine("History:");

            foreach (var memento in _mementos)
            {
                Console.WriteLine(memento.GetContent());
            }
        }
    }
}
