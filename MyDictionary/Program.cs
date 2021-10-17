using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> araclar = new List<string>();
            araclar.Add("Audi");
            araclar.Add("Audi");
            araclar.Add("Audi");
            araclar.Add("Audi");
            araclar.Add("Audi");
            Console.WriteLine(araclar.Count);
            MyList<string> araclar2 = new MyList<string>();
            araclar2.Add("Mercedes");
            araclar2.Add("Mercedes");
            araclar2.Add("Mercedes");
            araclar2.Add("Mercedes");
            Console.WriteLine(araclar2.Count);
        }
        class MyList<T>
        {
            T[] _array;
            T[] _tempArray;
            public MyList()
            {
               _array = new T[0];
            }
            public void Add (T item)
            {
                _tempArray = _array;
                _array = new T[_array.Length + 1];
                for (int i = 0; i < _tempArray.Length; i++)
                {
                    _array[i] = _tempArray[i];
                }
                _array[_array.Length - 1] =item;
            }
            public int Count
            {
                get{ return _array.Length; }
            }
        }
    }
}
