using System;

namespace HomeTask_3_2.Task2
{
    public class HashNode<TK, TV>
        where TK : IComparable<TK>
        where TV : IComparable<TV>
    {
        private TK _key;
        private TV _value;
        private HashNode<TK, TV> _next;
        private bool _isDeleted;

        public HashNode(TK key, TV value)
        {
            _key = key;
            _value = value;
        }

        public TK Key => _key;

        public TV Value
        {
            get => _value;
            set => _value = value;
        }

        public bool IsDeleted
        {
            get { return _isDeleted; }
            set { _isDeleted = value; }
        }

        public HashNode<TK, TV> Next
        {
            get => _next;
            set => _next = value;
        }
    }
}