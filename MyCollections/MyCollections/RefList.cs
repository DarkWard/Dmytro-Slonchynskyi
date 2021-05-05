using System;

namespace MyCollections
{
    public class RefList : IRefList
    {
        private Node _head;
        private Node _tail;
        private int _counter = 0;

        public int Count
        {
            get { return _counter; }
        }

        public object this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add(object value)
        {
            Node node = new Node(value);

            if (_head == null)
            {
                _head = node;
            }
            else
            {
                _tail.Next = node;
            }

            _tail = node;

            _counter++;
        }

        public void AddToEnd(object value)
        {
            Node node = new Node(value);

            if (_head == null)
            {
                _head = node;
            }
            else
            {
            }

            /*node = _head.Next;

            while (node.Next != null)
            {
                node = node.Next;
            }*/

            _counter++;
        }

        public void DeleteByIndex(int index)
        {
        }

        public void DeleteByValue(object value)
        {
        }

        public int IndexOf(object value)
        {
            if (_counter == 0)
            {
                return -1;
            }

            if (_head.Data == value)
            {
                return 0;
            }
            else
            {
                while (_head.Next != null)
                {
                }
            }

            return 0;
        }

        public object[] ToArray()
        {
            return null;
        }
    }
}