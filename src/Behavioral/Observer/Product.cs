using Observer.Abstracts;
using Observer.Constants;

namespace Observer;

public class Product : ISubject
{
    private List<IObserver> _observers = new();
    public string ProductName { get; set; }
    
    private int _stock;
    public int Stock
    {
        get => _stock;
        set
        {
            // if (value <= StockConstants.CriticalStockCount)
            // {
            //     _stock = value;
            //     Notify();
            // }
            // else
            // {
            //     _stock = value;
            // }

            _stock = value;
            Notify();
        }
    }

    public Product(string productName, int stock)
    {
        ProductName = productName;
        Stock = stock;
    }
    
    public void Register(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Remove(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update(ProductName, Stock);
        }
    }
}