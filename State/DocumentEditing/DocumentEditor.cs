using StateDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class DocumentEditor
    {
        private IEditingState currentState;

        public DocumentEditor()
        {
            currentState = new EditState(); // Initial state
        }

        public void SetState(IEditingState state)
        {
            currentState = state;
        }

        public void PerformEdit()
        {
            currentState.Edit();
        }
        public void PerformSelect()
        {
            currentState.Select();
        }
        public void PerformDraw()
        {
            currentState.Draw();
        }
    }
}
