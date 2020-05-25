using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Generic_Scale
{
    class Scale<T> where T : IComparable<T>

    {
        private T left;
        private T right;
        public Scale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }



        public T GetHeavier()
        {
             var com = left.CompareTo(right);

            if (com>0)
            {
                return left;
}
            else if(com<0)
            {
                return right;
            }
          

            return default(T);
            }

        }
    }

