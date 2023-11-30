using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern
{
    public class FileSystemIterator : IIterator<IFileSystemComponent>
    {
        private Stack<IEnumerator<IFileSystemComponent>> stack = new Stack<IEnumerator<IFileSystemComponent>>();

        public FileSystemIterator(IEnumerator<IFileSystemComponent> iterator)
        {
            stack.Push(iterator);
        }

        public IFileSystemComponent Current => stack.Peek().Current;

        public bool MoveNext()
        {
            var iterator = stack.Peek();
            if (iterator.MoveNext())
            {
                var component = iterator.Current;
                if (component is Directory directory)
                {
                    stack.Push(directory.GetEnumerator());
                }
                return true;
            }
            else
            {
                stack.Pop();
                return stack.Count > 0 && MoveNext();
            }
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
