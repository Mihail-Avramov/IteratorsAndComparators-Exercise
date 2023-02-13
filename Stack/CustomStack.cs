

using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private const int initialCapacity = 4;
        private T[] items;

        public CustomStack()
        {
            this.items = new T[initialCapacity];
            this.Count = 0;
        }

        public int Count { get; private set; }

        public void Push(T item)
        {
            if (this.Count == this.items.Length)
            {
                Resize();
            }

            this.items[Count] = item;

            this.Count++;
        }

        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }

            T removedItem = this.items[Count - 1];

            this.Count--;
            
            return removedItem;
        }

        private void Resize()
        {
            T[] copy = new T[this.items.Length * 2];

            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }

            this.items = copy;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                yield return this.items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
