using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Generic_Array_Creator
{
    class ArrayCreator
    {
        
        public static T[] Create<T>(int length, T item)
        {
            var array = new T[length];

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(i);
              Console.WriteLine (array[i] = item);

            }
            Console.WriteLine(array);
            return array;
        }
    }
}