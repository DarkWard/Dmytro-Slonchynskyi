using System.Collections;
using System.Collections.Generic;

namespace HomeTask_3_1.Task2

/*
 *  Написать обобщенный класс DataStore<T> реализующий следующие методы и свойства: Add(T item), Remove(T item), int Count, Items[].
 *  Использовать внутреннию структуру данных массив для хранения элементов хранилища.
*/
{
    public class DataStore<T> : IDataStore<T>, IEnumerable<T>
    {
        private int _count;
        private T[] _items;

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public T[] Items
        {
            get
            {
                return _items;
            }
        }

        public void Add(T item)
        {
            if (_count == 0)
            {
                _items = new T[] { item };
                _count++;
            }
            else
            {
                var temp = new T[_items.Length + 1];

                for (int i = 0; i < _items.Length; i++)
                {
                    temp[i] = _items[i];
                }

                temp[_items.Length] = item;

                _items = temp;
                _count++;
            }
        }

        public void Remove(T item)
        {
            if (_count == 0)
            {
                throw new DataStoreException("Store is empty!");
            }

            int counter = 0;

            foreach (var tmp in _items)
            {
                if (tmp.Equals(item))
                {
                    break;
                }
                else
                {
                    counter++;
                }
            }

            T[] result = new T[_items.Length - 1];

            for (int i = 0; i < counter; i++)
            {
                result[i] = _items[i];
            }

            for (int i = counter + 1; i < _items.Length; i++)
            {
                result[i - 1] = _items[i];
            }

            _items = result;
            _count--;
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
