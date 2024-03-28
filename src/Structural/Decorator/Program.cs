using Decorator;
using Decorator.Abstracts;
using Decorator.Decarators;

Coffee myCoffee = new BasicCoffee();
Console.WriteLine($"{myCoffee.Description}: {myCoffee.Cost()}");

myCoffee = new MilkDecarator(myCoffee);
Console.WriteLine($"{myCoffee.Description}: {myCoffee.Cost()}");

myCoffee = new SyrupDecarator(myCoffee);
Console.WriteLine($"{myCoffee.Description}: {myCoffee.Cost()}");