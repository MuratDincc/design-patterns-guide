using Observer;
using Observer.Observers;

var product = new Product("Laptop", 10);
// var criticalStockObserver = new CriticalStockObserver();
// product.Register(criticalStockObserver);

var stockTrackingObserver = new StockTrackingObserver();
product.Register(stockTrackingObserver);

product.Stock = 5;
product.Stock = 3;
product.Stock = 1;
product.Stock = 15;