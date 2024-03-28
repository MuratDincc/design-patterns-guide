using Proxy.Abstracts;

namespace Proxy;

public class PaymentProcessorProxy : IPaymentProcessor
{
    private PaymentProcessor _paymentProcessor;
    
    public void ProcessPayment(string creditCardNumber, decimal amount)
    {
        if (_paymentProcessor == null)
            _paymentProcessor = new PaymentProcessor();

        if (IsValidCreditCard(creditCardNumber))
            _paymentProcessor.ProcessPayment(creditCardNumber, amount);
        else
            Console.WriteLine("Invalid credit card number. Payment not processed.");
    }
    
    private bool IsValidCreditCard(string creditCardNumber)
    {
        return creditCardNumber.Length == 16;
    }
}