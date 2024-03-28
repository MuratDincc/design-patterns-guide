using Strategy.Abstracts;

namespace Strategy;

public class UpperCaseStrategy : ITextProcessingStrategy
{
    public string Process(string text)
    {
        return text.ToUpper();
    }
}