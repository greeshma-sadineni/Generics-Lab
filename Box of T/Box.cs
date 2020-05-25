using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Box_of_T
{
    class Box<T>
    { 
    int count { get; }
         List<T> l = new List<T>();
        public void Add(T element)
        {
            l.Add(element);
        }

        public T Remove()
        {
          T i= l[l.Count - 1];
            l.RemoveAt(l.Count - 1);
            return i;
        }
    }
}

