using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class DrawState : IEditingState
    {
        public void Edit()
        {
            Console.WriteLine("In Draw mode - Editing drawn shapes");
        }
        public void Select()
        {
            Console.WriteLine("In Draw mode - Selecting drawn shapes");
        }
        public void Draw()
        {
            Console.WriteLine("In Draw mode - Drawing shapes");
        }
    }
}
