using StateDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class SoldOutState : IVendingMachineState
    {
        public void InsertMoney(int amount)
        {
            Console.WriteLine("Machine is sold out");

        }

        public void EjectMoney()
        {
            Console.WriteLine("Machine is sold out");
        }

        public void SelectProduct(string product)
        {
            Console.WriteLine("Machine is sold out");
        }

        public void DispenseProduct()
        {
            Console.WriteLine("Machine is sold out");
        }
    }
}
