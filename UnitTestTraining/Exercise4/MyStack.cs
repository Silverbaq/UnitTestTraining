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
            // TODO: Implement code
        }

        public T Pop()
        {
            // TODO: Implement code
            return _items.First();
        }

        public T Peek()
        {
            // TODO: Implement code
            return _items.First();
        }

        public bool IsEmpty()
        {
            // TODO: Implement code
            return false;
        }
    }
}