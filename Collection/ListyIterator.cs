using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection
{
    internal class ListyIterator<T> : IEnumerable<T>
    {
        private int index = 0;
        private List<T> items;

        public ListyIterator(List<T> items)
        {
            this.items = items;
        }

        public bool Move()
        {
            if (index < items.Count - 1)
            {
                index++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            return index < items.Count - 1;
        }

        public void Print()
        {
            if (this.items.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine($"{this.items[index]}");
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in this.items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
