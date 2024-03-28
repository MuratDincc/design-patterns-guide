using Memento;

var editor = new Editor();
var history = new History();

editor.Content = "The first line";
history.Save(editor);

editor.Content = "The second line";
history.Save(editor);

Console.WriteLine($"Currenct Content: {editor.Content}");
history.Undo(editor);

Console.WriteLine($"After Undo: {editor.Content}");
history.Undo(editor);

Console.WriteLine($"After Undo: {editor.Content}");