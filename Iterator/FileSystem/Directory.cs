using IteratorDesignPattern;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern
{
    public class Directory : IFileSystemComponent, IEnumerable<IFileSystemComponent>
    {
        private List<IFileSystemComponent> components = new List<IFileSystemComponent>();

        public string Name { get; }

        public Directory(string name)
        {
            Name = name;
        }

        public void AddComponent(IFileSystemComponent component)
        {
            components.Add(component);
        }

        public IEnumerator<IFileSystemComponent> GetEnumerator()
        {
            return components.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
