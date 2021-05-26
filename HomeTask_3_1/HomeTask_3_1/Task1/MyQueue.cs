using System.Collections;
using System.Collections.Generic;

namespace HomeTask_3_1.Task1
{
    /*
     *  Реализовать структуру данных используя только массив:
     *  Очередь -> generic.
    */

    public class MyQueue<T> : IEnumerable<T>, IQueue<T>
    {
        private Node<T> _head;
        private Node<T> _tail;
        private int _count;

        public int Count
        {
            get { return _count; }
        }

        public void Enqueue(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> tmpNode = _tail;
            _tail = node;

            if (_count == 0)
            {
                _head = _tail;
            }
            else
            {
                tmpNode.Next = _tail;
            }

            _count++;
        }

        public T Dequeue()
        {
            if (_count == 0)
            {
                throw new QueueException("Queue is empty!");
            }

            T result = _head.Data;
            _head = _head.Next;
            _count--;

            return result;
        }

        public T Peek()
        {
            if (_count == 0)
            {
                throw new QueueException("Queue is empty!");
            }

            return _head.Data;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = _head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
