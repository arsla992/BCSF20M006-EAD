using IteratorDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern
{
    public class CollectionIterator<T> : IIterator<T>
    {
        private Collection<T> collection;
        private int index;

        public CollectionIterator(Collection<T> collection)
        {
            this.collection = collection;
            this.index = 0;
        }

        public T Current => collection[index];

        public bool MoveNext()
        {
            index++;
            return index < collection.Count;
        }

        public void Reset()
        {
            index = 0;
        }
    }
}
