using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProjectStatement
{
    public class ArrayInteger
    {
        public void MaximumElement(int[] intArray)
        {
            foreach (int element in intArray)
            {
                Console.Write(element+" ");
            }
            Console.WriteLine(" ");
            Array.Sort(intArray);
            int len = intArray.Length;
            Console.WriteLine("Maximum Element is:->"+intArray[len-1]);
        }
    }
}
