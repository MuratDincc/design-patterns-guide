using State.Abstracts;
using State.Domain;

namespace State.States;

public class ConfirmedOrderState : IOrderState
{
    public void Proceed(Order order)
    {
        Console.WriteLine("Order confirmed");
        order.SetState(new ShippedOrderState());
    }
}