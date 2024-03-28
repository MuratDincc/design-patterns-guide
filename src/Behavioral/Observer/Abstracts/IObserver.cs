namespace Observer.Abstracts;

public interface IObserver
{
    void Update(string productName, int stock);
}