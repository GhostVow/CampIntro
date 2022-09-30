using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericsIntro
{
    public class MyList<T>
    {
        T[] _items;

        public int Count => _items.Length;

        public T this[int index] { get { return _items[index]; } set { _items[index] = value; } }

        //constructor
        public MyList()
        {
            _items = new T[0];
        }
        
        public MyList(int capacity)
        {
            _items = new T[capacity];
        }

        public void Add(T item)
        {
            T[] tempArray = _items;

            _items = new T[Count+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                _items[i] = tempArray[i];
            }

            _items[Count-1] = item;
        }

        public void Remove(T item)
        {
            T[] tempArray = _items;

            _items = new T[Count-1];
            int index = 0;

            foreach (var value in tempArray)
            {
                if (value.Equals(item))
                {
                    continue;
                }
                
                _items[index] = value;
                index++;
            }

        }

        public void Clear()
        {
            _items = new T[0];
        }
        
    }
}
