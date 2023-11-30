using StateDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class EditState : IEditingState
    {
        public void Edit()
        {
            Console.WriteLine("In Edit mode - Editing document");
        }
        public void Select()
        {
            Console.WriteLine("In Edit mode - Selecting objects");
        }

        public void Draw()
        {
            Console.WriteLine("In Edit mode - Drawing shapes");
        }
    }
}
