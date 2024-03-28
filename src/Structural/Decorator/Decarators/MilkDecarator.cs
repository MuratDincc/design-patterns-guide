using Decorator.Abstracts;

namespace Decorator.Decarators;

public class MilkDecarator : CoffeeDecarator
{
    public MilkDecarator(Coffee coffee) : base(coffee)
    {
    }
    
    public override string Description => $"{_coffee.Description}, Milk";
    
    public override double Cost()
    {
        return _coffee.Cost() + 0.25;
    }
}