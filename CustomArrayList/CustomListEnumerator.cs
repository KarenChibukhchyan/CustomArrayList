using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomArrayList
{
    public class CustomListEnumerator : IEnumerator<object>
    {
        private readonly object[] _items;
        private int _index = -1;
        private int _size;

        public CustomListEnumerator(object[] items, int size)
        {
            _items = items;
            _size = size;
        }

        public bool MoveNext()
        {
            return ++_index < _size;
        }

        public void Reset()
        {
            _index = -1;
        }

        public object Current => _items[_index];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }
}