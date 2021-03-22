using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class MyList<T>  //Generic class
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T sehir)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            _array[_array.Length - 1] = sehir;
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
        }
        public T[] Gonder
        {
            get { return _array; }
        }
        public int Count
        {
            get { return _array.Length; }
        }

    }
}
