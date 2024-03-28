using Observer.Abstracts;

namespace Observer.Observers;

public class StockTrackingObserver : IObserver
{
    public void Update(string productName, int stock)
    {
        Console.WriteLine($"Stock Tracking Observer: {productName} stock is {stock} - Tracking Stock...");
    }
}