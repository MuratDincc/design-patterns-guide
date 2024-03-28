using Strategy.Abstracts;

namespace Strategy;

public class ReverseStrategy : ITextProcessingStrategy
{
    public string Process(string text)
    {
        char[] charArray = text.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}