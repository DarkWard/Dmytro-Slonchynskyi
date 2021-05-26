using System;
using System.Collections;

namespace HomeTask_3_1.Task3
{
    internal class MyEnumerator : IEnumerator
    {
        private string[] _array;
        private int _position = -1;
        public MyEnumerator(string[] days)
        {
            _array = days;
        }

        public object Current
        {
            get
            {
                if (_position == -1 || _position >= _array.Length)
                {
                    throw new InvalidOperationException();
                }

                return _array[_position];
            }
        }

        public bool MoveNext()
        {
            if (_position < _array.Length - 1)
            {
                _position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            _position = -1;
        }
    }
}
