using System;
using System.Collections.Generic;

namespace stack
{
    public class Stack
    {
        private List<object> _stack = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new NullReferenceException("Object cannot be null");

            _stack.Add(obj);
        }

        public object Pop()
        {
            var last = _stack.Count - 1;
            if (last < 0)
                throw new InvalidOperationException("You cannot pop object from an empty stack.");

            var output = _stack[last];
            _stack.RemoveAt(last);
            return output;
        }

        public void Clear()
        {
            _stack.Clear();
        }
    }
}
