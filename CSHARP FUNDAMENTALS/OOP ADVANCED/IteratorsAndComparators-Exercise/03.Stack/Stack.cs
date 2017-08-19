using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03.Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private readonly List<T> elements;

        public Stack()
        {
            this.elements = new List<T>();
        }

        public void Pop()
        {

            if (elements.Count > 0)
            {
                elements.Remove(elements.Last());
            }

            else
            {
                Console.WriteLine("No elements");

            }
        }

        public void Push(List<T> stack)
        {
            elements.AddRange(stack);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = elements.Count - 1; i >= 0 ; i--)
            {
                yield return elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}