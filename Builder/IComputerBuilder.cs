using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
   public  interface IComputerBuilder
    {
        void SetCPU();
        void SetRAM();
        void SetStorage();
        Computer GetComputer();
    }
}
