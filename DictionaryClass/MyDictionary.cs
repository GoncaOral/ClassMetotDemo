using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryClass
{
    class MyDictionary<Tkey,Tvalue>
    {
        Tkey[] _keys;
        Tvalue[] _values;
        Tkey[] _tempkeys;
        Tvalue[] _tempvalues;
        public MyDictionary()
        {
            _keys = new Tkey[0];
            _values = new Tvalue[0];

        }
      public  void Add(Tkey tkey , Tvalue tvalue)
      {
            _tempkeys = _keys;
            _tempvalues = _values;

            _keys = new Tkey[_keys.Length + 1];

            for (int i = 0; i < _tempkeys.Length; i++)
            {
                _keys[i] = _tempkeys[i];
            }
            _values = new Tvalue[_values.Length + 1];

            for (int i = 0; i < _tempvalues.Length; i++)
            {
                _values[i] = _tempvalues[i];
            }

            _keys[_keys.Length - 1] = tkey; 
            _values[_values.Length - 1] = tvalue;
      }
        public Tkey[] Keys 
        {
            get { return _keys; }                
        }
        public Tvalue[] Values
        {
            get { return _values; }
        }

        public void List()
        {
            for (int i = 0; i < _keys.Length; i++)
            {
                Console.WriteLine("Id:"+Keys[i]  + " Value:"+Values[i]);
            }
        }
    }
}
