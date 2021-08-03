using System;

namespace TwoLinkedList
{
    public class TwoLinkedList : RefList
    {
        private TwoLinkedNode _twoTail;

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
                    temp = temp.Next as TwoLinkedNode;
                }

                return temp.Data;
            }

            set
            {
                var add = new TwoLinkedNode(value);
                var current = _head as TwoLinkedNode;

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
            if (_head == null)
            {
                base.Add(value);
                _twoTail = _head.Next as TwoLinkedNode;
                _twoTail.Prev = _head as TwoLinkedNode;
            }
            else
            {
                TwoLinkedNode tmp = _tail as TwoLinkedNode;
                base.Add(value);
                _twoTail = _tail as TwoLinkedNode;
                _twoTail.Prev = tmp;
            }
        }

        public override void AddToEnd(object value)
        {
            Add(value);
        }

        public override void AddToBegin(object value)
        {
            if (_head == null)
            {
                base.AddToBegin(value);
            }
            else
            {
                TwoLinkedNode node = _head as TwoLinkedNode;
                base.AddToBegin(value);
                (_head as TwoLinkedNode).Prev = node;
            }
        }

        public override void DeleteByIndex(int index)
        {
            base.DeleteByIndex(index);

            TwoLinkedNode current = _head.Next as TwoLinkedNode;
            TwoLinkedNode prev = _head as TwoLinkedNode;

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
