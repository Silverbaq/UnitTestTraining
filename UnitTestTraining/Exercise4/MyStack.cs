using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestTraining.Exercise4
{
    public class MyStack<T>
    {
        private List<T> _items = new List<T>();

        public void Push(T item)
        {
            _items.Add(item);
        }

        public T Pop()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            int lastIndex = _items.Count - 1;
            T lastItem = _items[lastIndex];
            _items.RemoveAt(lastIndex);
            return lastItem;
        }

        public T Peek()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return _items[_items.Count - 1];
        }

        public bool IsEmpty()
        {
            return _items.Count == 0;
        }
    }
}