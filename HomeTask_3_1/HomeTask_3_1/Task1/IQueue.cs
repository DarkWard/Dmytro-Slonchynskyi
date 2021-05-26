namespace HomeTask_3_1.Task1
{
    public interface IQueue<T>
    {
        public int Count { get; }
        public void Enqueue(T item);
        public T Dequeue();
        public T Peek();
    }
}