using Proxy.Abstracts;

namespace Proxy;

public class PaymentProcessor : IPaymentProcessor
{
    public void ProcessPayment(string creditCardNumber, decimal amount)
    {
        Console.WriteLine($"Processing payment of {amount} with credit card {creditCardNumber}");
    }
}