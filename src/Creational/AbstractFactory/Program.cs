using AbstractFactory.Abstracts;
using AbstractFactory.Concrete.Coffee;
using AbstractFactory.Concrete.Tea;

IBeverageFactory beverageFactory = new CoffeeFactory();
IBeverage beverage = beverageFactory.CreateBeverage();
beverage.Prepare();

beverageFactory = new TeaFactory();
beverage = beverageFactory.CreateBeverage();
beverage.Prepare();
