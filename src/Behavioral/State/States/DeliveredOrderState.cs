using State.Abstracts;
using State.Domain;

namespace State.States;

public class DeliveredOrderState : IOrderState
{
    public void Proceed(Order order)
    {
        Console.WriteLine("Order delivered");
    }
}