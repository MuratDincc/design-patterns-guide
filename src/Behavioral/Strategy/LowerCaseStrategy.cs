using Strategy.Abstracts;

namespace Strategy;

public class LowerCaseStrategy : ITextProcessingStrategy
{
    public string Process(string text)
    {
        return text.ToLower();
    }
}