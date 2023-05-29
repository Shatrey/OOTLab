namespace Lab7
{
    internal class Editor
    {
        private string content;

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public EditorMemento Save()
        {
            return new EditorMemento(content);
        }

        public void Restore(EditorMemento memento)
        {
            content = memento.GetContent();
        }

        public void PrintContent()
        {
            Console.WriteLine("Current Content: " + content);
        }
    }
}
