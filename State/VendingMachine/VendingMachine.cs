using StateDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class VendingMachine
    {
        private IVendingMachineState currentState;

        public VendingMachine()
        {
            currentState = new NoMoneyState(); // Initial state
        }

        public void SetState(IVendingMachineState state)
        {
            currentState = state;
        }

        public void InsertMoney(int amount) => currentState.InsertMoney(amount);
        public void EjectMoney() => currentState.EjectMoney();
        public void SelectProduct(string product) => currentState.SelectProduct(product);
        public void DispenseProduct() => currentState.DispenseProduct();
    }
}
