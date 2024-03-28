namespace Iterator.Abstracts;

public interface IMenu
{
    IEnumerator<string> CreateIterator();
}