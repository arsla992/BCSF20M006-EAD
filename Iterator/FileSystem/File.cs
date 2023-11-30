using IteratorDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern
{
    public class File : IFileSystemComponent
    {
        public string Name { get; }

        public File(string name)
        {
            Name = name;
        }
    }
}
