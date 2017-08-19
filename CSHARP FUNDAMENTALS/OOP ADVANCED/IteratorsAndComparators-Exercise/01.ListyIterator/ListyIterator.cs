using System;
using System.Collections;
using System.Collections.Generic;

namespace _01.ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private readonly List<T> list;
        private int index;

        public ListyIterator(List<T> list)
        {
            this.List = list;
        }

        public List<T> List { get; }

        public bool Move(List<T> list)
        {
            if (this.HasNext(list))
            {
                index++;
                return true;
            }

            return false;
        }

        public bool HasNext(List<T> list)
        {
            if (index < list.Count - 1)
            {
                return true;
            }

            return false;
        }

        public void Print(List<T> list)
        {
            if (index < list.Count)
            {
                Console.WriteLine(list[index]);
            }
            else
            {
                Console.WriteLine("Invalid Operation!");
            }
        }

        public void PrintAll(List<T> list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < list.Count; i++)
            {
                yield return list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}