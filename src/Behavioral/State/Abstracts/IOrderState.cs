using State.Domain;

namespace State.Abstracts;

public interface IOrderState
{
    void Proceed(Order order);
}