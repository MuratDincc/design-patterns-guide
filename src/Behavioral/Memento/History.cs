namespace Memento;

public class History
{
    private Stack<TextEditor> _states = new Stack<TextEditor>();

    public void Save(Editor editor)
    {
        _states.Push(editor.Save());
    }
    public void Undo(Editor editor)
    {
        if (_states.Count > 0)
            editor.Restore(_states.Pop());
    }
}