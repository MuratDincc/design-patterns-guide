namespace Proxy.Abstracts;

public interface IPaymentProcessor
{
    void ProcessPayment(string creditCardNumber, decimal amount);
}