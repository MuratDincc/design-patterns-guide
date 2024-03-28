using System.Net.Mime;

namespace Memento;

public class Editor
{
    public string Content { get; set; }

    public TextEditor Save()
    {
        return new TextEditor(Content);
    }

    public void Restore(TextEditor textEditor)
    {
        Content = textEditor.Content;
    }
}