using StateDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class SelectState : IEditingState
    {
        public void Edit()
        {
            Console.WriteLine("In Select mode - Editing selected objects");
        }

        public void Select()
        {
            Console.WriteLine("In Select mode - Selecting objects");
        }
        public void Draw()
        {
            Console.WriteLine("In Select mode - Drawing selection outlines");
        }

    }
}
