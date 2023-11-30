using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public interface IEditingState
    {
        void Edit();
        void Select();
        void Draw();
    }

}
