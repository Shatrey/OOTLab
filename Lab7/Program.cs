using Lab7;

var editor = new Editor();
var careTaker = new Caretaker(editor);

editor.Content = "Initial";
careTaker.Backup();

editor.Content = "Change1";
careTaker.Backup();

editor.Content = "Change2";
careTaker.Backup();

Console.WriteLine($"Current state: {editor.Content}");
careTaker.ShowHistory();

careTaker.Undo();
Console.WriteLine($"State after Undo: {editor.Content}");