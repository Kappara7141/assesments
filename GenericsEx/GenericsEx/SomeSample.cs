using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsEx
{
    class SomeSample<T>
    {
        private T[] arr = new T[100];
        public T this[int i]
        {
            get
            {
                return arr[i];
            }
            set { arr[i] = value; }
        }

    }
}

