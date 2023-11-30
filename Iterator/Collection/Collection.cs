using IteratorDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern
{
    public class Collection<T> : IAggregate<T>
    {
        private List<T> items = new List<T>();

        public void AddItem(T item)
        {
            items.Add(item);
        }

        public IIterator<T> CreateIterator()
        {
            return new CollectionIterator<T>(this);
        }

        public int Count => items.Count;

        public T this[int index]
        {
            get { return items[index]; }
        }
    }
}
