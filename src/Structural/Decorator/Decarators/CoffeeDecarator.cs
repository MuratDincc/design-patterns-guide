using Decorator.Abstracts;

namespace Decorator.Decarators;

public abstract class CoffeeDecarator : Coffee
{
    protected Coffee _coffee;
    
    public CoffeeDecarator(Coffee coffee)
    {
        _coffee = coffee;
    }
}