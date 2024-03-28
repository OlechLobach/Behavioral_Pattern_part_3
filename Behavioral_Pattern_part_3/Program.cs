using StrategyPattern.Core;

namespace StrategyPattern.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var paymentContext = new PaymentContext(new CreditCardPaymentStrategy());
            paymentContext.ProcessPayment(100.50);

            paymentContext.SetPaymentStrategy(new PayPalPaymentStrategy());
            paymentContext.ProcessPayment(50.25);

            paymentContext.SetPaymentStrategy(new CashPaymentStrategy());
            paymentContext.ProcessPayment(30.00);
        }
    }
}