using System;

namespace HomeTask_3_1.Task2
{
    public interface IDataStore<T>
    {
        int Count { get; }
        T[] Items { get; }
        void Add(T item);
        void Remove(T item);
    }
}
