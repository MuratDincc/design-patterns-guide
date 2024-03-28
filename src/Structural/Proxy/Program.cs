using Proxy;
using Proxy.Abstracts;

IPaymentProcessor paymentProcessor = new PaymentProcessorProxy();
paymentProcessor.ProcessPayment("1234567890123456", 100);
paymentProcessor.ProcessPayment("abcdefg", 50);