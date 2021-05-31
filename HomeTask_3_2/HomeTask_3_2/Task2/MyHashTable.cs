using System;

namespace HomeTask_3_2.Task2
{
    public class MyHashTable<TK, TV>
        where TK : IComparable<TK>
        where TV : IComparable<TV>
    {
        private HashNode<TK, TV>[] _buckets;

        private int _count;

        public MyHashTable(int capacity)
        {
            _buckets = new HashNode<TK, TV>[capacity];
        }

        public int Count
        {
            get { return _count; }
        }

        public bool ContainsKey(TK key)
        {
            var index = Hash(key);
            var item = _buckets[index];

            if (item == null)
            {
                return false;
            }

            while (item != null)
            {
                if (item.Key.CompareTo(key) == 0)
                {
                    return true;
                }

                item = item.Next;
            }

            return false;
        }

        public bool ContainsValue(TV value)
        {
            foreach (var bucket in _buckets)
            {
                if (bucket == null)
                {
                    continue;
                }

                var item = bucket;
                while (item != null)
                {
                    if (item.Value.CompareTo(value) == 0)
                    {
                        return true;
                    }

                    item = item.Next;
                }
            }

            return false;
        }

        public TV Find(TK key)
        {
            var index = Hash(key);
            var item = _buckets[index];

            if (item == null)
            {
                return default;
            }

            while (item != null)
            {
                if (item.Key.CompareTo(key) == 0)
                {
                    return item.Value;
                }

                item = item.Next;
            }

            return default;
        }

        public void Add(TK key, TV value)
        {
            var index = Hash(key);
            var bucket = _buckets[index];

            while (bucket != null)
            {
                if (key.CompareTo(bucket.Key) == 0)
                {
                    bucket.Value = value;
                    return;
                }

                bucket = bucket.Next;
            }

            var item = new HashNode<TK, TV>(key, value) { Next = _buckets[index] };
            _buckets[index] = item;
            _count++;
        }

        public void Remove(TK key)
        {
            var index = Hash(key);
            var bucket = _buckets[index];
            HashNode<TK, TV> lastNode = null;

            while (bucket != null)
            {
                if (bucket.Key.CompareTo(key) == 0)
                {
                    _count--;
                    if (lastNode == null)
                    {
                        _buckets[index] = bucket.Next;
                    }
                    else
                    {
                        lastNode.Next = bucket.Next;
                    }
                }

                lastNode = bucket;
                bucket = bucket.Next;
            }
        }

        private int Hash(TK key)
        {
            return key == null ? 0 : Math.Abs(key.GetHashCode() % _buckets.Length);
        }
    }
}
