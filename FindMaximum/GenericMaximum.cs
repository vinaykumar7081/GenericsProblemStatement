using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximum
{
    public class GenericMaximum<T> where T : IComparable<T>
    {
        public T FindMaxElement(T[] array)
        {
            Array.Sort(array);
            int length_Array= array.Length;
            T element=array[length_Array-1];
            return element;
            
        }
    }
}
