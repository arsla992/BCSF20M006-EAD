using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattren
{
    public interface IPrototype  // We have to make a clone of Existing Object
    {
        IPrototype Clone();
    }
}
