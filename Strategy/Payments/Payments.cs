using StrategyDesignPattern;
using System;

public class Payments
{
    public static void Main(string[] args)
    {
        // Creating a payment context
        PaymentContext paymentContext = new PaymentContext();

        // Using Credit Card Payment strategy
        paymentContext.SetPaymentStrategy(new CreditCardPayment());
        paymentContext.ProcessPayment(50.0);

        // Using PayPal Payment strategy
        paymentContext.SetPaymentStrategy(new PayPalPayment());
        paymentContext.ProcessPayment(30.0);
    }
}



