using System;

namespace LinkedList
{
    public class RefList : IRefList
    {
        private Node _head;
        private Node _tail;
        private int _count;

        public int Count
        {
            get { return _count; }
        }

        public object this[int index]
        {
            get
            {
                if (index < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                var temp = _head;
                for (int i = 0; i < index; i++)
                {
                    temp = temp.Next;
                }

                return temp.Data;
            }

            set
            {
            }
        }

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

            _count++;
        }

        public void AddToEnd(object value)
        {
            Node node = new Node(value);

            if (_head == null)
            {
                _head = node;
                _tail = node;
            }
            else
            {
                _tail.Next = node;
                _tail = node;
            }

            _count++;
        }

        public void AddToBegin(object value)
        {
            Node node = new Node(value);

            if (_head == null)
            {
                _head = node;
                _tail = node;
            }
            else
            {
                node.Next = _head;
                _head = node;
            }

            _count++;
        }

        public void DeleteByIndex(int index)
        {
            if (index < 0 || index > _count)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (index == 0 && _head.Next != null)
            {
                _head = _head.Next;
            }
            else if (index == 0 && _head.Next == null)
            {
                _head = null;
                _tail = null;
            }

            var current = _head.Next;
            var prev = _head;

            for (int i = 1; i < index + 1; i++)
            {
                if (i == index)
                {
                    prev.Next = current.Next;

                    if (current.Next == null)
                    {
                        _tail = prev;
                    }

                    break;
                }

                prev = current;
                current = current.Next;
            }

            _count--;
        }

        public void DeleteByValue(object value)
        {
            while (true)
            {
                int index = 0;
                index = IndexOf(value);

                if (index == -1)
                {
                    break;
                }
                else
                {
                    DeleteByIndex(index);
                }
            }
        }

        public int IndexOf(object value)
        {
            if (_count == 0)
            {
                return -1;
            }

            if (_head.Data.Equals(value))
            {
                return 0;
            }
            else if (_tail.Data.Equals(value))
            {
                return _count - 1;
            }
            else
            {
                var temp = _head.Next;
                int index = 1;

                while (temp.Next != null)
                {
                    if (temp.Data.Equals(value))
                    {
                        return index;
                    }
                    else
                    {
                        temp = temp.Next;
                        index++;
                    }
                }
            }

            return -1;
        }

        public object[] ToArray()
        {
            var res = new object[_count];
            var node = _head;
            int index = 0;

            while (node != null)
            {
                res[index] = node.Data;
                node = node.Next;
                index++;
            }

            return res;
        }
    }
}