using Decorator.Abstracts;

namespace Decorator.Decarators;

public class SyrupDecarator : CoffeeDecarator
{
    public SyrupDecarator(Coffee coffee) : base(coffee)
    {
    }

    public override string Description => $"{_coffee.Description}, Syrup";
    
    public override double Cost()
    {
        return _coffee.Cost() + 2;
    }
}