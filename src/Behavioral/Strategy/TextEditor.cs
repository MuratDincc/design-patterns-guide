using Strategy.Abstracts;

namespace Strategy;

public class TextEditor
{
    private ITextProcessingStrategy _processingStrategy;

    public TextEditor(ITextProcessingStrategy processingStrategy)
    {
        _processingStrategy = processingStrategy;
    }
   
    public void SetStrategy(ITextProcessingStrategy processingStrategy)
    {
        _processingStrategy = processingStrategy;
    }
    
    public void ProcessText(string text)
    {
        Console.WriteLine(_processingStrategy.Process(text));
    }
}