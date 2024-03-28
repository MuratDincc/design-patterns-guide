using State.Abstracts;
using State.Domain;

namespace State.States;

public class NewOrderState : IOrderState
{
    public void Proceed(Order order)
    {
        Console.WriteLine("Order received");
        order.SetState(new ConfirmedOrderState());
    }
}