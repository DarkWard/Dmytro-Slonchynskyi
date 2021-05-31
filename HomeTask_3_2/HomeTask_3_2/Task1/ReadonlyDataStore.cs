using System.Collections;
using System.Collections.Generic;

namespace HomeTask_3_2.Task1
{
    public class ReadonlyDataStore<T> : IEnumerable<T>
    {
        private readonly T[] _items;
        private int _count;

        public ReadonlyDataStore(T[] input)
        {
            _items = input;
            _count = input.Length;
        }

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public IEnumerable<T> Items
        {
            get
            {
                foreach (var item in _items)
                {
                    yield return item;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            var counter = 0;

            while (counter != _count)
            {
                yield return _items[counter];
                counter++;
            }
        }
    }
}