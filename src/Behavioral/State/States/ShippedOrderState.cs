using State.Abstracts;
using State.Domain;

namespace State.States;

public class ShippedOrderState : IOrderState
{
    public void Proceed(Order order)
    {
        Console.WriteLine("Order shipped");
        order.SetState(new DeliveredOrderState());
    }
}