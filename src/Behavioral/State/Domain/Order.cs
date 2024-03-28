using State.Abstracts;
using State.States;

namespace State.Domain;

public class Order
{
    private IOrderState _state;
    
    public Order()
    {
        _state = new NewOrderState();
    }

    public void SetState(IOrderState state)
    {
        _state = state;
    }

    public void NextState()
    {
        _state.Proceed(this);
    }
}