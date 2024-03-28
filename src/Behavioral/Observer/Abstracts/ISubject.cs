namespace Observer.Abstracts;

public interface ISubject
{
    void Register(IObserver observer);
    void Remove(IObserver observer);
    void Notify();
}