using Observer.Abstracts;

namespace Observer.Observers;

public class CriticalStockObserver : IObserver
{
    public void Update(string productName, int stock)
    {
        Console.WriteLine($"Critical Stock Observer: {productName} stock is {stock} - Critical Stock!!!");
    }
}