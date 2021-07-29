using System;

namespace TwoLinkedList
{
    public class TwoLinkedList : RefList
    {
        private TwoLinkedNode _twoHead;
        private TwoLinkedNode _twoTail;

        public override object this[int index]
        {
            get
            {
                if (index < 0 || index > _count - 1)
                {
                    throw new ArgumentOutOfRangeException();
                }

                var temp = _twoHead;
                for (int i = 0; i < index; i++)
                {
                    temp = temp.Next as TwoLinkedNode;
                }

                return temp.Data;
            }

            set
            {
                var add = new TwoLinkedNode(value);
                var current = _twoHead;

                for (int i = 0; i < index; i++)
                {
                    current = current.Next as TwoLinkedNode;
                }

                current.Prev.Next = add;
                add.Next = current;
                add.Prev = current.Prev;
                current.Prev = add;

                _count++;
            }
        }

        public override void Add(object value)
        {
            var node = new TwoLinkedNode(value);

            if (_twoHead == null)
            {
                _twoHead = node;
                _head = _twoHead;
            }
            else
            {
                _twoTail.Next = node;
                node.Prev = _twoTail;
            }

            _twoTail = node;
            _tail = _twoTail;
            _count++;
        }

        public override void AddToEnd(object value)
        {
            var node = new TwoLinkedNode(value);

            if (_twoHead == null)
            {
                _twoHead = node;
                _head = _twoHead;
                _twoTail = node;
                _tail = _twoTail;
            }
            else
            {
                _twoTail.Next = node;
                node.Prev = _twoTail;
                _twoTail = node;
                _tail = _twoTail;
            }

            _count++;
        }

        public override void AddToBegin(object value)
        {
            var node = new TwoLinkedNode(value);

            if (_twoHead == null)
            {
                _twoHead = node;
                _head = _twoHead;
                _twoTail = node;
                _tail = _twoTail;
            }
            else
            {
                node.Next = _twoHead;
                _twoHead.Prev = node;
                _twoHead = node;
                _head = _twoHead;
            }

            _count++;
        }

        public override void DeleteByIndex(int index)
        {
            base.DeleteByIndex(index);

            TwoLinkedNode current = _twoHead.Next as TwoLinkedNode;
            TwoLinkedNode prev = _twoHead;

            for (int i = 0; i < index + 1; i++)
            {
                if (i == index)
                {
                    TwoLinkedNode tmp = current.Next as TwoLinkedNode;
                    tmp.Prev = current.Prev;

                    if (current.Next == null)
                    {
                        _twoTail = prev;
                    }

                    break;
                }

                prev = current;
                current = current.Next as TwoLinkedNode;
            }
        }

        public override void DeleteByValue(object value)
        {
            base.DeleteByValue(value);
        }

        public override int IndexOf(object value)
        {
            return base.IndexOf(value);
        }

        public override object[] ToArray()
        {
            return base.ToArray();
        }
    }
}
