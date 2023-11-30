using StateDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class HasMoneyState : IVendingMachineState
    {
        public void InsertMoney(int amount)
        {
            Console.WriteLine($"Already have money. Total: ${amount}");
        }

        public void EjectMoney()
        {
            Console.WriteLine("Money ejected");
        }

        public void SelectProduct(string product)
        {
            Console.WriteLine($"Selected {product}");
        }

        public void DispenseProduct()
        {
            Console.WriteLine("Product dispensed");
        }
    }
}
