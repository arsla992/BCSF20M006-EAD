using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public interface IVendingMachineState
    {
        void InsertMoney(int amount);
        void EjectMoney();
        void SelectProduct(string product);
        void DispenseProduct();
    }
}
