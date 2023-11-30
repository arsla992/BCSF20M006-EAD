using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    class PaymentContext
    {
        private IPaymentStrategy paymentStrategy;

        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            paymentStrategy = strategy;
        }

        public void ProcessPayment(double amount)
        {
            paymentStrategy.ProcessPayment(amount);
        }
    }

}
