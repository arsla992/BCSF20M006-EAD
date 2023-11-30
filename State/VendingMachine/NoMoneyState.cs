using StateDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class NoMoneyState : IVendingMachineState
    {
        public void InsertMoney(int amount)
        {
            Console.WriteLine($"Inserted ${amount}");
            // Update internal state, e.g., change to 'HasMoneyState'
        }

        public void EjectMoney()
        {
            Console.WriteLine("No money to eject");
        }

        public void SelectProduct(string product)
        {
            Console.WriteLine("Insert money first");

        }

        public void DispenseProduct()
        {
            Console.WriteLine("Insert money and select product");
        }
    }

}
