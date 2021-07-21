using System;

namespace TwoLinkedList
{
    public class TwoLinkedList : RefList
    {
        private TwoLinkedNode _head;
        private TwoLinkedNode _tail;
        private int _count;

        public override int Count
        {
            get { return _count; }
        }

        public override object this[int index]
        {
            get
            {
                if (index < 0 || index > _count - 1)
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
                var add = new TwoLinkedNode(value);
                var current = _head;

                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }

                current.Prev.Next = add;
                add.Next = current;
                add.Prev = current.Prev;
                current.Prev = add;

                _count++;
            }
        }

        public override void Add(object data)
        {
            var node = new TwoLinkedNode(data);

            if (_head == null)
            {
                _head = node;
            }
            else
            {
                _tail.Next = node;
                node.Prev = _tail;
            }

            _tail = node;
            _count++;
        }

        public override void AddToEnd(object value)
        {
            var node = new TwoLinkedNode(value);

            if (_head == null)
            {
                _head = node;
                _tail = node;
            }
            else
            {
                _tail.Next = node;
                node.Prev = _tail;
                _tail = node;
            }

            _count++;
        }

        public override void AddToBegin(object value)
        {
            var node = new TwoLinkedNode(value);

            if (_head == null)
            {
                _head = node;
                _tail = node;
            }
            else
            {
                node.Next = _head;
                _head.Prev = node;
                _head = node;
            }

            _count++;
        }

        public override void DeleteByIndex(int index)
        {
            if (index < 0 || index > _count)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (index == 0 && _head.Next != null)
            {
                _head = _head.Next;
                _head.Prev = null;
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
                    current.Next.Prev = current.Prev;

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

        public override void DeleteByValue(object value)
        {
            for (int i = 0; i < _count - 1; i++)
            {
                int index = IndexOf(value);

                if (index != -1)
                {
                    DeleteByIndex(index);
                }
            }
        }

        public override int IndexOf(object value)
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

        public override object[] ToArray()
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
